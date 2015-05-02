<%@ Page Title="People" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="People.aspx.cs" Inherits="ContactsSquared.People" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>People</h1>


    <div class="row">
    <div class="col-md-12">
        <div class="col-md-12">
            <input type="text" class="form-control search" placeholder="Search">
        </div>
        <div class="col-md-12">
            <ul class="alphabet">
                <li>A</li>
                <li>B</li>
                <li>C</li>
                <li>D</li>
                <li>E</li>
                <li>F</li>
                <li>G</li>
                <li>H</li>
                <li>I</li>
                <li>J</li>
                <li>K</li>
                <li>L</li>
                <li>M</li>
                <li>N</li>
                <li>O</li>
                <li>P</li>
                <li>Q</li>
                <li>R</li>
                <li>S</li>
                <li>T</li>
                <li>U</li>
                <li>V</li>
                <li>W</li>
                <li>X</li>
                <li>Y</li>
                <li>Z</li>
            </ul>
        </div>
    </div>
</div>
<hr />
<div class="row">
    <div class="col-md-12">
        <ul class="people">
            <li><img src="images/img-person.png" alt="Name" class="img-rounded profile-icon"></li>
            <li><label class="profile-txt">John Doe</label></li>
        </ul>
    </div>
</div>


</asp:Content>
