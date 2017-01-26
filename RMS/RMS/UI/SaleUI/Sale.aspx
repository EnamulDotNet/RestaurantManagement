<%@ Page Title="" Language="C#" MasterPageFile="~/Rms.Master" AutoEventWireup="true" CodeBehind="Sale.aspx.cs" Inherits="RMS.UI.Sale.Sale" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-4 col-md-offset-1 form-group salepagediv">
    <table >
        <tr>
            <td>
                <label for="Product Code">Poduct Code</label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtProductCode" CssClass="form-control" ClientIDMode="Static" AutoPostBack="True"></asp:TextBox>
            </td>
            </tr>
        <tr>
            <td>
                <label for="Product Name ">Product Name</label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtProductName" CssClass="form-control" ClientIDMode="Static" AutoPostBack="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <label>Product Price</label>
            </td>
            <td>
             <asp:TextBox runat="server" ID="txtProductPrice" CssClass="form-control" ReadOnly="True" BorderStyle="None"></asp:TextBox>
            </td>
            <td>
                <asp:Label runat="server" Text="TK."></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <label>Product Stock</label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtProductStock" CssClass="form-control" ReadOnly="True" BorderStyle="none"></asp:TextBox>
            </td>
            <td>
                <asp:Label runat="server" ID="lblMeasurementUnit" Text="Unit"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <label>Sell Quantity</label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtSellQty" CssClass="form-control" ClientIDMode="Static" AutoPostBack="True"></asp:TextBox>
            </td>
            <td>
                <asp:Label runat="server" ID="lblSellMeasurementUnit" Text="Unit"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <label>Total Price</label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtTotalPrice" CssClass="form-control" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
                <label>TK.</label>
            </td>
        </tr>
        <tr>
            <td>
                <label>Due Amount</label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtDueAmount" CssClass="form-control" ReadOnly="True" BorderStyle="None"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <label>Grand Total</label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtGrandTotal" CssClass="form-control" ClientIDMode="Static" ReadOnly="True" BorderStyle="None"></asp:TextBox>
            </td>
            <td>
                <label>TK.</label>
            </td>
            
        </tr>
        <tr>
            <td>
                <label>Discount Amount</label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtDiscountAmount" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
            </td>
            <td>
                <label>TK.</label>
            </td>
        </tr>
        <tr>
            <td>
                <label>Amount to be Paid</label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtAmountToBePaid" CssClass="form-control" ReadOnly="True"></asp:TextBox>
            </td>
           <td>
               <label>TK.</label>
           </td>
        </tr>
        <tr>
            <td>
                <label>Paid Amount</label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtPaidAmount" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
            </td>
            <td>
                <label>TK.</label>
            </td>
        </tr>
        <tr>
            <td>
                <label>Finally Due Amount</label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtFinallyDueAmount" CssClass="form-control" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        </table>
    </div>
    <div class="col-md-5 col-md-offset-0 form-group salepagediv">
     <table class="form-group">
            <tr >
            <td>
                <label for="Customer ID" >Customer ID &nbsp;</label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtCustomerId" CssClass="form-control" ClientIDMode="Static" AutoPostBack="True"></asp:TextBox>
            </td>
        </tr>
         <tr>
             <td>
                 <label for="Customer Username"> Customer Username</label>
             </td>
             <td>
                 <asp:TextBox runat="server" ID="txtCustomerUsername" CssClass="form-control" ClientIDMode="Static" AutoPostBack="True"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td>
                 <label>Customer Due</label>
             </td>
             <td>
                 <asp:TextBox runat="server" ID="txtCustomerDue" CssClass="form-control" ClientIDMode="Static" BorderStyle="None" ReadOnly="True"></asp:TextBox>
             </td>
             <td>
                 <asp:Label runat="server" Text="TK."></asp:Label>
             </td>
         </tr>
    </table>
        </div>
</asp:Content>
