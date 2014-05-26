using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ScrewTurn2Markdown {
    public static class StringHelpers {
        private static readonly Regex Up = new Regex(@"\{UP\}", RegexOptions.Compiled | RegexOptions.Singleline);
        private static readonly Regex UpRelative = new Regex(@"\{UP\((.+?)\)\}", RegexOptions.Compiled | RegexOptions.Singleline);
 
        public static string Apply(this string str, Regex expression, string replacement) {
            return expression.Replace(str, replacement);
        }

        public static string Apply(this string str, Regex expression, MatchEvaluator evaluator) {
            return expression.Replace(str, evaluator);
        }

        public static string EscapeForMarkdown(this string nowikiSection) {
            return nowikiSection
                .Replace("\\", "\\\\")
                .Replace("`", "\\`")
                .Replace("*", "\\*")
                .Replace("_", "\\_")
                .Replace("{", "\\{")
                .Replace("}", "\\}")
                .Replace("[", "\\[")
                .Replace("]", "\\]")
                .Replace("(", "\\(")
                .Replace(")", "\\)")
                .Replace("#", "\\#")
                .Replace("+", "\\+")
                .Replace("-", "\\-")
                .Replace(".", "\\.")
                .Replace("!", "\\!");
        }

        public static string ConvertLink(Match match) {
            var url = RemoveNewWindowLinkCharacter(match.Groups[2].Value);
            var text = match.Groups.Count > 4 ? match.Groups[4].Value.Trim() : "";
            if (String.IsNullOrWhiteSpace(text) && url.IndexOf('-') == -1) text = url;
            var before = match.Groups[1];
            if (url.StartsWith("mailto:")) {
                url = url.Substring(7);
                // Strip parameters
                var question = url.IndexOf('?');
                if (question != -1) url = url.Substring(0, question);
                return before + "<" + url + ">";
            }
            if (String.IsNullOrEmpty(text)) {
                return before + "<" + url + ">";
            }
            return before + "[" + text + "](" + url + ")";
        }

        public static string RemoveNewWindowLinkCharacter(string url) {
            return url[0] == '^' ? url.Substring(1) : url;
        }

        public static string ConvertUp(this string str) {
            return Up.Replace(str, m => "../Upload" + (str[m.Index + m.Length] == '/' ? "" : "/"));
        }

        public static string ConvertUpRelative(this string str) {
            return UpRelative.Replace(str, m => "../Attachments/" + m.Groups[1].Value + (str[m.Index + m.Length] == '/' ? "" : "/"));
        }

        public static string FormatMarkdownCodeSample(Match match) {
            var reader = new StringReader(match.Groups[1].Value);
            var writer = new StringWriter();
            while (true) {
                var line = reader.ReadLine();
                if (line == null) break;
                writer.WriteLine("    " + line);
            }
            return writer.ToString();
        }

        public static string ConvertEnumerations(this string content) {
            // Only supporting enumeration and sub-enumeration here. Because I don't need more.
            var reader = new StringReader(content);
            var writer = new StringWriter();
            var count1 = 0;
            var count2 = 0;
            while (true) {
                var line = reader.ReadLine();
                if (line == null) break;
                if (line.StartsWith("** ")) {
                    writer.WriteLine("    * " + line.Substring(3));
                    count1 = count2 = 0;
                }
                else if (line.StartsWith("*# ")) {
                    writer.WriteLine("    " + ++count2 + ". " + line.Substring(3));
                    count1 = 0;
                }
                else if (line.StartsWith("#* ")) {
                    writer.WriteLine("    * " + line.Substring(3));
                    count2 = 0;
                }
                else if (line.StartsWith("## ")) {
                    writer.WriteLine("    " + ++count2 + ". " + line.Substring(3));
                }
                else if (line.StartsWith("# ")) {
                    writer.WriteLine(++count1 + ". " + line.Substring(2));
                    count2 = 0;
                }
                else {
                    writer.WriteLine(line);
                    count1 = count2 = 0;
                }
            }
            return writer.ToString();
        }

        public static string ConvertTables(this string content) {
            //{| cellspacing="0" cellpadding="2" style="background-color: #EEEEEE;"
            //|+ Styled Table
            //! Cells x.1 !! Cells x.2 !! Cells x.3
            //|- style="background-color: #990000; color: #FFFFFF;"
            //| This is a cell || This is a cell || This is a cell
            //|-
            //| style="background-color: #000000; color: #CCCCCC;" | Styled cell
            //| style="border: solid 1px #FF0000;" | Styled cell
            //| '''Normal cell'''
            //|-
            //| Normal || Normal || [Download]
            //|}
            var reader = new StringReader(content);
            var writer = new StringWriter();
            var inTable = false;
            var inarow = false;
            while (true) {
                var line = reader.ReadLine();
                if (line == null) break;
                if (inTable) {
                    if (line.Trim() == "|}") {
                        if (inarow) writer.WriteLine("</tr>");
                        writer.WriteLine("</table>");
                        inTable = false;
                    }
                    else if (line.StartsWith("|+ ")) {
                        writer.WriteLine("<caption>" + line.Substring(3) + "</caption>");
                    }
                    else if (line.Trim() == "|-") {
                        if (inarow) {
                            writer.Write("</tr>");
                        }
                        var attributes = line.Length > 3 ? line.Substring(3).Trim() : "";
                        writer.WriteLine(attributes.Length == 0 ? "<tr>" : "<tr " + attributes + ">");
                        inarow = true;
                    }
                    else if (line.StartsWith("! ")) {
                        writer.WriteLine("<thead><tr>");
                        foreach (var cell in line.Substring(2).Split(new[] { " !! " }, StringSplitOptions.RemoveEmptyEntries)) {
                            writer.WriteLine("<td>" + cell + "</td>");
                        }
                        writer.WriteLine("</tr></thead>");
                    }
                    else if (line.StartsWith("| ")) {
                        var separator = line.IndexOf(" | ");
                        if (separator != -1) {
                            writer.WriteLine("<td " + line.Substring(2, separator - 2) + ">" + line.Substring(separator + 3));
                        }
                        else {
                            foreach (var cell in line.Substring(2).Split(new[] { " || " }, StringSplitOptions.RemoveEmptyEntries)) {
                                writer.WriteLine("<td>" + cell + "</td>");
                            }
                        }
                    }
                }
                else if (line.StartsWith("{|")) {
                    var attributes = line.Length > 3 ? line.Substring(3).Trim() : "";
                    writer.WriteLine(attributes.Length == 0 ? "<table>" : "<table " + attributes + ">");
                    inTable = true;
                }
                else {
                    writer.WriteLine(line);
                }
            }
            return writer.ToString();
        }

        public static string RemoveToc(this string content) {
            var reader = new StringReader(content);
            var writer = new StringWriter();
            while (true) {
                var line = reader.ReadLine();
                if (line == null) break;
                if (line.Trim() != "{TOC}") writer.WriteLine(line);
            }
            return writer.ToString();
        }
    }
}
