<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="COMP229_006_Project_1.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div>
        <div id="game1">
            <h1><b>GAME-1</b></h1>
        </div>
        <div id="game3">
            <h1><b>GAME-3</b></h1>
        </div>
    </div>

    <img id="bg" src="Assets/images/bg.png"/>

    <div>
        <div id="game2">
            <h1><b>GAME-2</b></h1>            
        </div>

        <div id="game4">
            <h1><b>GAME-4</b></h1>
        </div>
       

        
   
   
        
        </div>
            <div id="new">
 <button id="btn" type="button"><b>Previous Week</b></button>
             <button id="btn2" type="button" ><b>Next Week</b></button>
        </div>

</asp:Content>
