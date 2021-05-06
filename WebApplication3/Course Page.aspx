<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Course Page.aspx.cs" Inherits="WebApplication3.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%:"Course Page" %></h2>
    <head>
   <meta name="viewport" content="width=device-width" />
   <title>Sample YouTube Embed Video Example</title>
</head>
<body>
   <iframe id="YouTubevideo" width="420" height="315"
      frameborder="0" style="display:none"
      allowfullscreen></iframe>
   <script type="text/javascript"
      src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3
      /jquery.min.js"></script>
   <script type="text/javascript">
      $("body").on("click", "#PlayVideo", function () {
         var url = $("#YoutubeUrl").val();
         url = url.split('v=')[1];
         $("#YouTubevideo")[0].src = "//www.youtube.com/embed/" +
            url;
         $("#YouTubevideo").show();
      });
   </script>
</body>
</asp:Content>
