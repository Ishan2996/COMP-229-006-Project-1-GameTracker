<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Week15.aspx.cs" Inherits="COMP229_006_Project_1.Week15" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div>

        <div id="game1">
            <h4 class="h6"><b>Football</b></h4>
             <a href="FootballDetails.aspx" class="btn btn-success btn-sm">
                    <i class="fa fa-plus"></i> Add Score
                </a>
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
            <h3 class="h6"><b>Basketball</b></h3>
               <a href="BasketballDetails.aspx" class="btn btn-success btn-sm">
                    <i class="fa fa-plus"></i> Add Score
                </a>
            <asp:GridView ID="basketball" runat="server" AutoGenerateColumns="false"
                CssClass="table table-bordered table-striped table-hover">
                <Columns>
                    <asp:BoundField DataField="TeamName1" HeaderText="Team" Visible="true" />
                    <asp:BoundField DataField="TeamScore1" HeaderText="Score" Visible="true" />
                    <asp:BoundField DataField="Spectators1" HeaderText="Spectators" Visible="true" />
                </Columns>
            </asp:GridView>
        </div>
    </div>

    <img id="bg" src="Assets/images/bg.png" />

    <div>
        <div id="game2">
            <h3 class="h6"><b>Hockey</b></h3>
             <a href="HockeyDetails.aspx" class="btn btn-success btn-sm">
                    <i class="fa fa-plus"></i> Add Score
                </a>
            <asp:GridView ID="hockey" runat="server" AutoGenerateColumns="false"
                CssClass="table table-bordered table-striped table-hover">
                <Columns>
                    <asp:BoundField DataField="TeamName1" HeaderText="Team" Visible="true" />
                    <asp:BoundField DataField="TeamScore1" HeaderText="Score" Visible="true" />
                    <asp:BoundField DataField="Spectators1" HeaderText="Spectators" Visible="true" />
                </Columns>
            </asp:GridView>
        </div>

        <div id="game4">
           <h3 class="h6"><b>Volleyball</b></h3>
            <a href="VolleyballDetails.aspx" class="btn btn-success btn-sm">
                    <i class="fa fa-plus"></i> Add Score
                </a>
            <asp:GridView ID="volleyball" runat="server" AutoGenerateColumns="false"
                CssClass="table table-bordered table-striped table-hover">
                <Columns>
                    <asp:BoundField DataField="TeamName1" HeaderText="Team" Visible="true" />
                    <asp:BoundField DataField="TeamScore1" HeaderText="Score" Visible="true" />
                    <asp:BoundField DataField="Spectators1" HeaderText="Spectators" Visible="true" />
                </Columns> 
            </asp:GridView>
        </div>



    </div>
 </asp:Content> 

