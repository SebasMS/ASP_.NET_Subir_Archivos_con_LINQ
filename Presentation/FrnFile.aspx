<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrnFile.aspx.cs" Inherits="Presentation.FrnFile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form" runat="server">
    <div style="width:200px; height:80px; margin: 0 auto;">
        <table>
            <tr>
                <td colspan="2"><asp:Label ID="lblTitle" runat="server" Text="Insertar Archivo a la Base de Datos"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2"><asp:FileUpload ID="fuFile" runat="server"/></td>
            </tr>
            <tr>
                <td><asp:Button ID="btnAccept" runat="server" Text="Aceptar" OnClick="btnAccept_Click" /></td>
                <td><asp:Label ID="lblResult" runat="server" ForeColor="#0000CC"></asp:Label></td>
            </tr>
        </table>        
    </div>
    </form>
</body>
</html>
