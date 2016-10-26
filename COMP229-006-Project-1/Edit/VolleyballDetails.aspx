<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="VolleyballDetails.aspx.cs" Inherits="COMP229_006_Project_1.VolleyballDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>

        <div id="game1">
            <h4><b>Volleyball Week-12</b></h4>
            

                <div class="form-group">
                    <label class="control-label" for="TeamaTextBox">Team Name</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TeamaTextBox" 
                        placeholder="Team" required="true"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="control-label" for="TeambTextBox">Team Score</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TeambTextBox" 
                        placeholder="Team Score" required="true"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="control-label" for="SpectatorsTextBox">Spectators</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="SpectatorsTextBox" 
                        placeholder="Spectators" required="true"></asp:TextBox>
                </div>

            <div class="text-right">
                    <asp:Button Text="Cancel" ID="CancelButton" CssClass="btn btn-warning btn-lg" runat="server"
                        UseSubmitBehavior="false" CausesValidation="false" OnClick="CancelButton_Click" />
                    <asp:Button Text="Save" ID="SaveButton" CssClass="btn btn-primary btn-lg" runat="server"
                        OnClick="SaveButton_Click" />
</div>
        </div>

        <div id="game3">
            
            <h4><b>Volleyball Week-13</b></h4>
            

                <div class="form-group">
                    <label class="control-label" for="TeamaTextBox">Team Name</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TextBox1" 
                        placeholder="Team" required="true"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="control-label" for="TeambTextBox">Team Score</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TextBox2" 
                        placeholder="Team Score" required="true"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="control-label" for="SpectatorsTextBox">Spectators</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TextBox3" 
                        placeholder="Spectators" required="true"></asp:TextBox>
                </div>

            <div class="text-right">
                    <asp:Button Text="Cancel" ID="Button1" CssClass="btn btn-warning btn-lg" runat="server"
                        UseSubmitBehavior="false" CausesValidation="false" OnClick="CancelButton_Click" />
                    <asp:Button Text="Save" ID="Button2" CssClass="btn btn-primary btn-lg" runat="server"
                        OnClick="SaveButton_Click" />
</div>
        </div>
    </div>




    <div>
        <div id="game2">
            <h4><b>Volleyball Week-14</b></h4>
            

                <div class="form-group">
                    <label class="control-label" for="TeamaTextBox">Team Name </label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TextBox4" 
                        placeholder="Team" required="true"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="control-label" for="TeambTextBox">Team Score</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TextBox5" 
                        placeholder="Team Score" required="true"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="control-label" for="SpectatorsTextBox">Spectators</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TextBox6" 
                        placeholder="Spectators" required="true"></asp:TextBox>
                </div>

            <div class="text-right">
                    <asp:Button Text="Cancel" ID="Button3" CssClass="btn btn-warning btn-lg" runat="server"
                        UseSubmitBehavior="false" CausesValidation="false" OnClick="CancelButton_Click" />
                    <asp:Button Text="Save" ID="Button4" CssClass="btn btn-primary btn-lg" runat="server"
                        OnClick="SaveButton_Click" />
</div>

        </div>

        <div id="game4">
             <h4><b>Volleyball Week-15</b></h4>
            

                <div class="form-group">
                    <label class="control-label" for="TeamaTextBox">Team Name</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TextBox7" 
                        placeholder="Team" required="true"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="control-label" for="TeambTextBox">Team Score</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TextBox8" 
                        placeholder="Team Score" required="true"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="control-label" for="SpectatorsTextBox">Spectators</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TextBox9" 
                        placeholder="Spectators" required="true"></asp:TextBox>
                </div>

            <div class="text-right">
                    <asp:Button Text="Cancel" ID="Button5" CssClass="btn btn-warning btn-lg" runat="server"
                        UseSubmitBehavior="false" CausesValidation="false" OnClick="CancelButton_Click" />
                    <asp:Button Text="Save" ID="Button6" CssClass="btn btn-primary btn-lg" runat="server"
                        OnClick="SaveButton_Click" />
</div>
        </div>

    </div>


</asp:Content>
