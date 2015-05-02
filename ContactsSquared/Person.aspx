<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Person.aspx.cs" Inherits="ContactsSquared.Person" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <hr />
<div class="row">
    <!-- Profile image for user 160 x 160 pixels -->
    <div class="col-xs-12 col-sm-3 col-md-2">
        <img src="images/img-person-profile.png" class="img-responsive profile-image" />
    </div>
    
    <div class="col-xs-12 col-sm-9 col-md-10">
        <!-- contact-style located in Site.css -->
        <ul class="contact-style">
            <!-- Name of Person -->
            <li>
                <asp:Label runat="server"><img src="images/icon_phone.png" class="icon-space" />Name</asp:Label>
                    <ol>
                        <li><asp:Label runat="server">John Doe</asp:Label></li>
                    </ol>
            </li>
            <!-- Phone Number of Person -->
            <li>
                <asp:Label runat="server"><img src="images/icon_phone.png" class="icon-space" />Phone Number</asp:Label>
                <ol>
                    <li>
                        <asp:Label runat="server">559-869-9600</asp:Label>
                    </li>
                </ol>
            </li>
            <!-- Cellphone Number of Person -->
            <li>
                <asp:Label runat="server"><img src="images/icon_phone.png" class="icon-space" />CellPhone Number</asp:Label>
                <ol>
                    <li>
                        <asp:Label runat="server">559-869-9600</asp:Label>
                    </li>
                </ol>
            </li>
            <!-- Email of Person -->
            <li>
                <asp:Label runat="server"><img src="images/icon_phone.png" class="icon-space" />Email</asp:Label>
                <ol>
                    <li><asp:Label runat="server">JohnDoe@gmail.com</asp:Label></li>
                </ol>
            </li>

            <!-- Address of Person -->
            <li>
                <asp:Label runat="server"><img src="images/icon_phone.png" class="icon-space" />Home Address</asp:Label>
                <ol>
                    <li><asp:Label runat="server">893 Vineyard Way<br />Kingsburg, CA 96786</asp:Label></li>
                </ol>
            </li>
        </ul>
    </div>
</div>

<hr />

<div class="row">
    <div class="col-md-12">
        <!-- Style For Social Media Located in alphabet.css -->
        <ul class="social-media">
            <li><img src="images/social_linkedin_circle.png" /></li>
            <li><img src="images/social_instagram_circle.png" /></li>
            <li><img src="images/social_facebook_circle.png" /></li>
            <li><img src="images/social_tumblr_square.png" /></li>
            <li><img src="images/social_twitter.png" /></li>
            <li><img src="images/social_skype_circle.png" /></li>
            <li><img src="images/social_googleplus_circle.png" /></li>
            <li><img src="images/social_pinterest_circle.png" /></li>
        </ul>
    </div>
</div>
</asp:Content>
