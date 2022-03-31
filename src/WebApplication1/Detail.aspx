<%@ Page Title="Detail" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="WebApplication1.Detail" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <table style="width:100%;">
        
    <% foreach(var x in GetAllPerson())
            {
            %>
        <tr><td> <%=x.FirstName %></td><td><%=x.LastName %></td></tr>
        <%
            } 
       %>

    </table>
</asp:Content>
