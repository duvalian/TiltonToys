<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="TiltonToys.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Contact Us.</h3>
    <address>
        12578 Woodfield Cir W.<br />
        Jacksonville, FL 32258<br />
        <abbr title="Phone">P:</abbr>
        904.624.9242
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:cmtilton@live.com">cmtilton@live.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:cmtilton@live.com">cmtilton@live.com</a>
    </address>
</asp:Content>
