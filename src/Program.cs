using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Path = Fluent.IO.Path;

namespace ScrewTurn2Markdown {
    /// <summary>
    /// Quick and dirty conversion from ScrewTurn Wiki to Markdown.
    /// The first command-line parameter is ScrewTurn's Public directory, the second is the destination directory.
    /// </summary>
    /// <remarks>
    /// This makes no claim at exhaustivity, it only aims at correctly converting http://orchardproject.net/docs.
    /// As such, I'm not handling transclusions, signatures, namespaces, indentation, tags and redirects.
    /// You will need to copy the attachments and upload folders from the wiki's public directory to the markdown destination folder.
    /// </remarks>
    public class Program {
        private static readonly Regex RevisionEx = new Regex(@"^.*\.\d{5}\.cs$", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
        private static readonly Regex Bold = new Regex(@"'''(.+?)'''", RegexOptions.Compiled | RegexOptions.Singleline);
        private static readonly Regex Italic = new Regex(@"''(.+?)''", RegexOptions.Compiled | RegexOptions.Singleline);
        private static readonly Regex Underlined = new Regex(@"__(.+?)__", RegexOptions.Compiled | RegexOptions.Singleline);
        private static readonly Regex Strike = new Regex(@"([^!])--(.+?)--", RegexOptions.Compiled | RegexOptions.Singleline);
        private static readonly Regex Separator = new Regex(@"----", RegexOptions.Compiled | RegexOptions.Singleline);
        private static readonly Regex InlineCode = new Regex(@"\{\{(.+?)\}\}", RegexOptions.Compiled | RegexOptions.Singleline);
        private static readonly Regex CodeBlock = new Regex(@"@@(.+?)@@", RegexOptions.Compiled | RegexOptions.Singleline);
        // How lazy can you be when perf is not at stake and you're writing a single-use tool? A lot.
        private static readonly Regex H1 = new Regex(@"==(.+?)==", RegexOptions.Compiled | RegexOptions.Singleline);
        private static readonly Regex H2 = new Regex(@"===(.+?)===", RegexOptions.Compiled | RegexOptions.Singleline);
        private static readonly Regex H3 = new Regex(@"====(.+?)====", RegexOptions.Compiled | RegexOptions.Singleline);
        private static readonly Regex H4 = new Regex(@"=====(.+?)=====", RegexOptions.Compiled | RegexOptions.Singleline);
        private static readonly Regex H5 = new Regex(@"======(.+?)======", RegexOptions.Compiled | RegexOptions.Singleline);
        private static readonly Regex H6 = new Regex(@"=======(.+?)=======", RegexOptions.Compiled | RegexOptions.Singleline);
        private static readonly Regex Box = new Regex(@"\(\(\((.+?)\)\)\)", RegexOptions.Compiled | RegexOptions.Singleline);
        private static readonly Regex Link = new Regex(@"([^!])\[(.+?)(\|(.+?))?\]", RegexOptions.Compiled | RegexOptions.Singleline);
        private static readonly Regex NoWiki = new Regex(@"<nowiki>(.+?)</nowiki>", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
        private static readonly Regex NoWikiRestore = new Regex(@"<nowiki:(\d+?)/>", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
        private static readonly Regex Literal = new Regex(@"(\{\{|@@)(.+?)(\}\}|@@)", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
        private static readonly Regex LiteralRestore = new Regex(@"<literal:(\d+?)/>", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
        private static readonly Regex Img = new Regex(@"\[image(right|auto|left|)\|(.*?)\|(.*?)(\|(.*?))?\]", RegexOptions.Compiled | RegexOptions.Singleline);
        private static readonly Regex Anchor = new Regex(@"\[anchor\|#(.+?)\]", RegexOptions.Compiled | RegexOptions.Singleline);

        public static void Main(string[] args) {
            var source = Path.Get(args.Length > 0 ? args[0] : @"\\ottawa\c$\inetpub\apex-net.it\Apex-net DOC\public");
            var dest = Path.Get(args.Length > 1 ? args[1] : @"H:\MyWorks\C#\Screwturn2markdown\SourcePages");
            source.Combine("Pages")
                .Files(p => !RevisionEx.IsMatch(p.FileName))
                .Read((content, path) => {
                          Console.WriteLine(path.FileName);
                          // Skipping first four lines (metadata)
                          var reader = new StringReader(content);
                          reader.ReadLine();
                          reader.ReadLine();
                          reader.ReadLine();
                          reader.ReadLine();
                          content = reader.ReadToEnd();
                          if (content == null) return;
                          // OK, using regular expressions, not ideal, I know, but I need to get that done. Shame on me. No perf pressure here, also.
                          // Do not change the order of these operations: it is meaningful.
                          var nowikiSections = new List<string>();
                          var literalSections = new List<string>();
                          content = content
                              .Apply(Literal, m => {
                                                  literalSections.Add(m.Groups[0].Value);
                                                  return "<literal:" + (literalSections.Count - 1) + "/>";
                                              })
                              .Apply(NoWiki, m => {
                                                 nowikiSections.Add(m.Groups[1].Value.EscapeForMarkdown());
                                                 return "<nowiki:" + (nowikiSections.Count - 1) + "/>";
                                             })
                              .Apply(Bold, "**$1**")
                              .Apply(Italic, "_$1_") // must be after bold.
                              .Apply(Underlined, "<span style=\"text-decoration:underline\">$1</span>")
                              .Apply(Separator, "- - -")
                              .Apply(Strike, "$1<del>$2</del>")
                              .ConvertEnumerations() // Must be before headers
                              .ConvertTables()
                              .RemoveToc()
                              .Apply(H6, "###### $1")
                              .Apply(H5, "##### $1")
                              .Apply(H4, "#### $1")
                              .Apply(H3, "### $1")
                              .Apply(H2, "## $1")
                              .Apply(H1, "# $1")
                              .Apply(Box, "> $1")
                              .Replace("{br}", "  \r\n")
                              .ConvertUp()
                              .ConvertUpRelative()
                              .Apply(Anchor, "")
                              .Apply(Img, "![$2]($3)") // must be before link
                              .Apply(Link, StringHelpers.ConvertLink)
                              .Apply(NoWikiRestore, m => nowikiSections[int.Parse(m.Groups[1].Value)])
                              .Apply(LiteralRestore, m => literalSections[int.Parse(m.Groups[1].Value)])
                              .Apply(InlineCode, "`$1`")
                              .Apply(CodeBlock, StringHelpers.FormatMarkdownCodeSample)
                              .Replace("<nowiki>", "")
                              .Replace("</nowiki>", "")
                              .Replace('’', '\'')
                              .Replace("®", "&reg;")
                              .Replace("©", "&copy;")
                              .Replace("™", "&trade;")
                              .Replace("–", "-")
                              .Replace("»", "&raquo;")
                              .Replace("«", "&laquo;");
                          dest.Combine(path.ChangeExtension(".markdown").FileName)
                              .Write(content);
                      });
        }
    }
}
