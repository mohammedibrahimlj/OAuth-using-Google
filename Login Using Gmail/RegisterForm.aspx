<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterForm.aspx.cs" Inherits="Login_Using_Gmail.RegisterForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <script type="text/javascript">
        function EmptyValues(val)
        {
            var name = val.value;
            if (name == "")
            {
                alert("This field cannot be null");
                return false;
               
            }
            
        }
        function check()
        {
            var name = document.getElementById("Name").value
            var dob = document.getElementById("dob").value
            var pass = document.getElementById("pass").value
            var cpass = document.getElementById("cpass").value
            var mail = document.getElementById("mail").value
            if(pass!=cpass)
            {
                alert("password and confirm password must be same");
                return false;
            }
            if (Date(dob) == false)
            {
                alert("in Valid Date");
                return false;
            }
            if ((length(name) == 0) || (length(dob) == 0) || (length(pass) == 0)||(length(mail)==0))
            {
                alert("Fields cannot be null");
                return false;
            }
            return true;
        } 
    </script>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>
                Name:
            </td>
            <td>
                <input id="Name" runat="server"  type="text" onblur='EmptyValues(this);'/>
            </td>
        </tr>
                <tr>
            <td>
                DateOfBirth:
            </td>
            <td>
                <input id="dob" runat="server"  type="date" onblur='EmptyValues(this);'/>
            </td>
        </tr>
         <tr>
            <td>
                Password
            </td>
            <td>
                <input id="pass" runat="server"  type="password" onblur='EmptyValues(this);'/>
            </td>
        </tr>
         <tr>
            <td>
                Confirmed Password
            </td>
            <td>
                <input id="cpass" runat="server"  type="password" onblur='EmptyValues(this);'/>
            </td>
        </tr>
        <tr>
            <td>
                Email
            </td>
            <td>
                <input id="mail" runat="server"  type="email" onblur='EmptyValues(this);'/>
            </td>
        </tr>
          <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" OnClientClick="return check();"/>
               
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
