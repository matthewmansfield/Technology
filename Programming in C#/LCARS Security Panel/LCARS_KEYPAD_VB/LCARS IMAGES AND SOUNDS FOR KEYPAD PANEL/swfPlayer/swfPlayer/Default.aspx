<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Upload a swf File</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
        <table width="410px">
            <tr>
                <td align="center"  style="width: 410px; border-style:solid ; border-bottom-color :Navy ; border-top-color :Navy ; border-left-color :Navy ; border-right-color :Navy; border-width :thin" valign="top">
                    <table border="0" cellpadding="2" cellspacing="3" style="width: 400px;">
                        <tr>
                            <td valign="top" style="width: 150px">
                            </td>
                            <td align="left" valign="top" style="width: 200px">
                                <asp:Label ID="lblMsg" CssClass="tdMessage"  Text ="" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td valign="top" class="tdText" align="left">
                              <nobr> Select a file</nobr> </td>
                            <td valign="top" style="text-align: left">
                                <asp:FileUpload ID="fUpload" runat="server" Width="300px" /></td>
                        </tr>
                        <tr>
                            <td align="left" valign="top">
                                <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" /></td>
                            <td align="left" valign="top">
                                <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=7,0,19,0"
                                    width="200" height="100">
                                    <param name="movie" value="<% =swfFileName%>" />
                                    <param name="quality" value="high" />
                                    <embed src="<% =swfFileName%>" quality="high" pluginspage="http://www.macromedia.com/go/getflashplayer"
                                        type="application/x-shockwave-flash" width="200" height="100"></embed>
                                </object>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
