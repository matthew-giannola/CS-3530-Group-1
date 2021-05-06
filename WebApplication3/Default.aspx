<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="CourseDB" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:ButtonField HeaderText="Classes" ShowHeader="True" Text="1430" />
            <asp:ButtonField Text="Button" />
            <asp:ButtonField Text="Button" />
            <asp:ButtonField Text="Button" />
            <asp:ButtonField Text="Button" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="CourseDB" runat="server"></asp:SqlDataSource>
</asp:Content>
