<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <button onclick="doWork(); return false;">DoWork</button>
        <button onclick="doSquare(); return false;">DoSquare</button>
        <input  type="text" id="squareValue"/>
    </div>

    <script type="text/javascript">
        function doWork() {
            console.info('Hello');

            $.ajax({
                url: "/Service/Service1.svc/DoWork",
                type: "GET",
                dataType: "json",
                success: function (result) {
                    console.info(result);
                }
            });
        
        }

        function doSquare() {
            var value = $("#squareValue").val();

            $.ajax({
                url: "/Service/Service1.svc/DoSquare",
                type: "POST",
                data: JSON.stringify(value),
                dataType: "json",
                contentType: "application/json",
                success: function (result) {
                    console.info(result);
                }
            });
        }

    </script>

</asp:Content>

