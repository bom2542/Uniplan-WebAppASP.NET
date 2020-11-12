<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoalReport.aspx.cs" Inherits="UniplanProject_G03.Reports.GoalReport" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <rsweb:reportviewer runat="server"></rsweb:reportviewer>
        </div>
    </form>
</body>
</html>
