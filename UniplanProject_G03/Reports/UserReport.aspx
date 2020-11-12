﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserReport.aspx.cs" Inherits="UniplanProject_G03.Reports.UserReport" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>  
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" width="100%"></rsweb:ReportViewer>
        </div>
    </form>
</body>
</html>
