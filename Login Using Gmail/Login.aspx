<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Login_Using_Gmail.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<script src="https://apis.google.com/js/platform.js" async defer></script>
<meta name="google-signin-client_id" content="824052358574-elos80touua6o4pui2v2ispts73e5gum.apps.googleusercontent.com">
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>
                UserName:
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

            </td>
        </tr>
                <tr>
            <td>
                Password:
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            </td>
            <td>
                <div class="g-signin2" data-onsuccess="onSignIn"></div>
            </td>
        </tr>
    </table>
    </div>
    </form>
    <script>
    function onSignIn(googleUser) {
        var profile = googleUser.getBasicProfile();
        console.log('ID: ' + profile.getId()); // Do not send to your backend! Use an ID token instead.
        console.log('Name: ' + profile.getName());
        console.log('Image URL: ' + profile.getImageUrl());
        console.log('Email: ' + profile.getEmail());
        window.location.replace("GoogleLoginAjax.aspx?email=" + profile.getEmail());
    }

    function signOut() {
        var auth2 = gapi.auth2.getAuthInstance();
        auth2.signOut().then(function () {
            console.log('User signed out.');
        });
    }
</script>
</body>
</html>
