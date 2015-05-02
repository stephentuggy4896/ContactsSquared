<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Person.aspx.cs" Inherits="ContactsSquared.Person" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <hr />
    <div class="row">
        <!-- Profile image for user 160 x 160 pixels -->
        <div class="col-xs-12 col-sm-3 col-md-2">
            <img src="images/img-person-profile.png" class="img-responsive profile-image" />
        </div>
    

    <asp:TextBox ID="PersonNameTextBox" runat="server" style="float: left">Name</asp:TextBox>
    <br />
    <h2 class="contact-details">Phone #'s</h2>

    <asp:Button ID="AddNumber"
        Text="Add Phone #"
        
        runat="server" />
    
    <asp:GridView ID="PhoneNumberGridView"
        autogeneratecolumns="false"
        emptydatatext="No data available."
        CssClass="contact-details"
        runat="server">
        <columns>
            <asp:BoundField DataField="PhoneNumberTypeOne" HeaderText="Phone # Type 1" />
            <asp:BoundField DataField="PhoneNumberTypeTwo" HeaderText="Phone # Type 2" />
            <asp:BoundField DataField="PhoneNumber" HeaderText="Phone #" />
        </columns>
    </asp:GridView>

    <asp:Button ID="DelNumber"
        Text="Delete Phone #"
        
        runat="server" />

    <h2>Email's</h2>

    <asp:Button ID="AddEmail"
        Text="Add Email Address"
        
        runat="server" />

    <asp:GridView ID="EmailGridView"
        autogeneratecolumns="false"
        emptydatatext="No data available."
        runat="server"
        CssClass="contact-details">
        <columns>
            <asp:BoundField DataField="EmailTypeOne" HeaderText="Email Type 1" />
            <asp:BoundField DataField="EmailTypeTwo" HeaderText="Email Type 2" />
            <asp:BoundField DataField="Email" HeaderText="Email" />
        </columns>
    </asp:GridView>

    <asp:Button ID="DelEmail"
        Text="Delete Email Address"
        
        runat="server" />
    
    <h2>Addresses</h2>

    <asp:Button ID="AddAddress"
        Text="Add Address"
        
        runat="server" />

     <asp:GridView ID="AddressGridView"
        autogeneratecolumns="false"
        emptydatatext="No data available."
        runat="server"
        CssClass="contact-details">
        <columns>

            <asp:BoundField DataField="AddressTypeOne" HeaderText="Address Type 1" />
            <asp:BoundField DataField="AddressTypeTwo" HeaderText="Address Type 2" />
            <asp:BoundField DataField="Address" HeaderText="Address" />
       
             </columns>
    </asp:GridView>

    <asp:Button ID="DelAddress"
        Text="Delete Address"
        
        runat="server" />

    <h2>Websites</h2>
    
    <asp:Button ID="AddWeb"
        Text="Add Website"
        
        runat="server" />

     <asp:GridView ID="WebSitesGridView"
        autogeneratecolumns="false"
        emptydatatext="No data available."
        CssClass="contact-details"
        runat="server">
        <columns>
            <asp:BoundField DataField="WebSiteTypeOne" HeaderText="Website Type 1" />
            <asp:BoundField DataField="WebSiteTypeTwo" HeaderText="Website Type 2" />
            <asp:BoundField DataField="WebSiteurl" HeaderText="URL" />
        </columns>
    </asp:GridView>

    <asp:Button ID="DelWebsite"
        Text="Delete Website"
       
        runat="server" />



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
