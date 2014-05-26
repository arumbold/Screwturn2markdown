per trasformarlo da un normale round Panel:

![](../Upload/aspxrpnormal.bmp)


ad uno di tipo GroupBox:

![](../Upload/aspxrpgroup.bmp)

####  PROBLEMA  alla rel. 8.2.5 quelli di devExpress non gestistcono bene i loro stili standard:

[vedi nostra segnalazione a DevExpress Support](http://www.devexpress.com/issue=B133927)

####  SOLUZIONE 
Sostituiamo l'attributo:
     xml 
    <pages theme="Office2003 Blue">
 
con
     xml
    <pages styleSheetTheme="Office2003 Blue"> 

del web.config.{BR}
{BR}Dopo aver trascinato il nuovo ASPxRoundPanel sostituiamo l'intestazione:
     xml
    <dxrp:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="200px">
    ...

con:
     xml
    <dxrp:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="200px" View="GroupBox">
            <HeaderStyle BackColor=" ">
                <BorderBottom BorderWidth="0px" />
            </HeaderStyle>
            <TopEdge>
                <BackgroundImage ImageUrl=" " />
            </TopEdge>
    ..

e il gioco è fatto.
