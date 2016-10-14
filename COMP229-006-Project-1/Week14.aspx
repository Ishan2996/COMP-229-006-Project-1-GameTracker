<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Week14.aspx.cs" Inherits="COMP229_006_Project_1.Week14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div>

        <div id="game1">
            <h4 class="h6"><b>Football</b></h4>

            <asp:GridView ID="football" runat="server" AutoGenerateColumns="false" 
                CssClass="table table-bordered table-striped table-hover">
                <Columns>
                    <asp:BoundField DataField="TeamName1" HeaderText="Team" Visible="true" />
                    <asp:BoundField DataField="TeamScore1" HeaderText="Score" Visible="true" />
                    <asp:BoundField DataField="Spectators1" HeaderText="Spectators" Visible="true" />

                </Columns>
            </asp:GridView>

        </div>
        <div id="game3">
            <h1><b>GAME-3</b></h1>
        </div>
    </div>

    <img id="bg" src="Assets/images/bg.png" />

    <div>
        <div id="game2">
            <h1><b>GAME-2</b></h1>
        </div>

        <div id="game4">
            <h1><b>GAME-4</b></h1>
        </div>



    </div>
 </asp:Content> 