<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyApp.Web.Default" %>
<%@ Register tagPrefix="uc" tagName="ProductListView" src="ProductList.ascx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>MyApp</title>
    </head>
    <body>
        
        <form id="form1" runat="server">
            <div>
                Hello World!
                
                <div>
                    <uc:ProductListView ID="UcProductListView" runat="server" />
                </div>

            </div>
        </form>
    </body>
</html>