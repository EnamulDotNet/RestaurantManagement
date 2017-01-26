<%@ Page Title="" Language="C#" MasterPageFile="~/Rms.Master" AutoEventWireup="true" CodeBehind="ReturnSale.aspx.cs" Inherits="RMS.UI.SaleUI.ReturnSale" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" ID="pnlInvoiceNo">
        <table>
            <tr>
                <td>
                    <label>Invoice No.</label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtSaleInvoiceNumber" CssClass="form-control" ClientIDMode="Static" AutoPostBack="False"></asp:TextBox>
                </td>
                <td>
                    <label>Total Price</label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtTotalPrice" CssClass="form-control" ClientIDMode="Static" ReadOnly="True" Enabled="False"></asp:TextBox>
                </td>
                <td>
                    <label>Discount</label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtDiscount" CssClass="form-control" ClientIDMode="Static" ReadOnly="True" Enabled="False"></asp:TextBox>
                </td>
                <td>
                    <label>Paid Amount</label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtPaidAmount" CssClass="form-control" ClientIDMode="Static" ReadOnly="True" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            </table>
        </asp:Panel>
    <br/>
    <asp:Panel runat="server" ID="pnlCustomer" Visible="False" >
        <table>
            <tr>
                <td>
                    <label>Customer Name</label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtCustomerName" CssClass="form-control" ClientIDMode="Static" ReadOnly="True" Enabled="False"></asp:TextBox>
                </td>
                <td>
                    <label>Paid by this invoice</label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtPaidByThisInvoice" CssClass="form-control" ClientIDMode="Static" ReadOnly="False" Enabled="False"></asp:TextBox>
                </td>
                <td>
                    <label>Due by this invoice</label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtDueByThisInvoice" CssClass="form-control" ClientIDMode="Static" ReadOnly="True" Enabled="False"></asp:TextBox>
                </td>
                <td>
                    <label>Total due</label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtTotalDue" CssClass="form-control" ClientIDMode="Static" ReadOnly="True" Enabled="False"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br/>
    </asp:Panel>
    
    <asp:panel runat="server" ID="pnlProductList" Visible="True">
        <table>
            <tr>
                <td>
                    <label>Product Code</label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtSaleReturnProductCode" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
                </td>
                <td>
                    <label>Product Name</label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtSaleReturnProductName" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
                </td>
                <td>
                    <label>Price per unit</label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtPricePerUnitReturnSale" CssClass="form-control" ClientIDMode="Static" ReadOnly="True" Enabled="False"></asp:TextBox>
                </td>
                <td>
                    <label>VAT</label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtVatReturnSale" CssClass="form-control" ClientIDMode="Static" ReadOnly="True" Enabled="False"></asp:TextBox>
                </td>
                </tr>
            

            <tr>
                <td>
                    <label>Return Qty</label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtReturnQty" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
                </td>
                <td>
        <asp:Button runat="server" ID="btnAdd" Text="Add" CssClass="btn btn-primary" ClientIDMode="Static" OnClick="btnAdd_Click"/>
                    
                </td>
                <td></td>
                <td>
                    <label>Sell Qty</label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtSellQtyReturnSale" CssClass="form-control" ClientIDMode="Static" ReadOnly="True" Enabled="False"></asp:TextBox>
                </td>
                </tr>
            </table>
        
        </asp:panel>
    <asp:Panel runat="server" ID="pnlGvReturn" Visible="False">
        <asp:GridView runat="server" ID="GvReturnSell" AutoGenerateColumns="False" AllowPaging="True" DataKeyNames="ProductId" ShowHeaderWhenEmpty="True" EmptyDataText="No product sell yet." OnRowDataBound="GvReturnSell_OnRowDataBound" ShowFooter="True" OnRowDeleting="GvReturnSell_OnRowDeleting">
            <HeaderStyle CssClass="gvheaderstyle"></HeaderStyle>
            <RowStyle CssClass="gvrowstyle"></RowStyle>
            <Columns>
                <asp:BoundField DataField="ProductId" HeaderText="Product Id" Visible="False"/>
                <asp:BoundField DataField="ProductName" HeaderText="Product Name"/>
                <asp:BoundField DataField="ProductQty" HeaderText="Quantity"/>
                <asp:BoundField DataField="ProductPricePerUnit" HeaderText="Price Per Unit"/>
                <asp:BoundField DataField="ProductVat" HeaderText="VAT(%)"/>
                <asp:BoundField DataField="ProductTotalPrice" HeaderText="Total Price"/>
                <asp:CommandField HeaderText="Action" ButtonType="Button" ShowDeleteButton="True" CausesValidation="False" />
            </Columns>
            <PagerSettings Mode="NextPreviousFirstLast" FirstPageText="First" NextPageText="Next" LastPageText="Last" PreviousPageText="Previous"></PagerSettings>
            <PagerStyle BackColor="#000084" BorderColor="Blue" BorderWidth="1" Font-Underline="true" ForeColor="White" Font-Bold="true" HorizontalAlign="Center" />

        </asp:GridView>
    </asp:Panel>
    <asp:Panel runat="server" ID="pnlToBeReturn" Visible="True">
        <br/>
        <table>
            <tr>
                <td>
                    <label>Return Amount</label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtReturnAmount" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
                </td>

                <td>
                    <label>To be return</label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtToBeReturn" CssClass="form-control" ClientIDMode="Static" ReadOnly="True" Enabled="False"></asp:TextBox>
                </td>
                
                <td>
                    <label>Remark</label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtRemark" CssClass="form-control" ClientIDMode="Static" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td>
                    
                </td>
                <td>
                    <asp:Button runat="server" ID="btnSaveReturn" Text="Return" CssClass="btn btn-primary" ClientIDMode="Static" OnClick="btnSaveReturn_Click"/>
                </td>
            </tr>

        </table>
    </asp:Panel>
    
    <%--<script>
        function UpdateStatusFadeOut(id, miliSec) {
             //alert(element);
            $("#" + id).fadeOut(miliSec);
            //window.location.replace("CreateSale.aspx");
            //window.location.href = "CreateSale.aspx";
        }
    </script>--%>
    <script>
  //      $("#txtQty")
  //.keypress(function () {
  //    var $num1 = parseFloat($(this).val(), 10) || 0;
  //    var $num2 = parseFloat($("#txtProductPricePerUnit").val(), 10) || 0;
  //    $("#txtTotalPriceOfWholeQty").val($num1 + $num2);
  //});
        
        $(function () {
             $('#txtSaleInvoiceNumber').autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: "../WebServices/AutoCompleteService.asmx/SearchSaleInvoiceNumber",
                        data: "{'searchText': '" + request.term + "' }",
                        type: "POST",
                        dataType: "Json",
                        contentType: "application/json;charset=utf-8",
                        success: function (data) {
                            response(data.d);
                        },
                        error: function (result) {
                            alert('Not Match');
                        }
                    });
                },
                 
                change: function () {
                    $.ajax({
                        url: "../WebServices/AutoCompleteService.asmx/GetInvoiceInfo",
                        data: "{'invoiceNo': '" + this.value + "' }",
                        type: "POST",
                        dataType: "json",
                        contentType: "application/json;charset=utf-8",
                        success: function (data) {
                            $('#txtTotalPrice').val(data.d.TotalAmount.toFixed(2));
                            $('#txtDiscount').val(data.d.DiscountAmount.toFixed(2));
                            $('#txtPaidAmount').val(data.d.PaidAmount.toFixed(2));
                        },
                        error: function (result) {
                            alert('Not Match');
                        }
                    });
                 }


             });
            ///////////////////////////////////////
             $('#txtSaleReturnProductCode').autocomplete({
                 source: function (request, response) {
                     var invoice = $('#txtSaleInvoiceNumber').val();
                     $.ajax({
                         url: "../WebServices/AutoCompleteService.asmx/SearchProductIdForSaleReturn",
                         data: "{'productId': '" + request.term + "', 'invoiceNumber': '" + invoice + "' }",
                         type: "POST",
                         dataType: "Json",
                         contentType: "application/json;charset=utf-8",
                         success: function (data) {
                             response(data.d);
                         },
                         error: function (result) {
                             alert('Not Match');
                         }
                     });
                 },
                 change: function () {
                     var invoice = $('#txtSaleInvoiceNumber').val();
                     $.ajax({
                         url: "../WebServices/AutoCompleteService.asmx/GetSaleProductInfo",
                         data: "{'productId': '" + this.value + "', 'invoiceNumber': '" + invoice + "' }",
                         type: "POST",
                         dataType: "json",
                         contentType: "application/json;charset=utf-8",
                         success: function (data) {
                             $('#txtSaleReturnProductName').val(data.d[1].Value);
                             $('#txtPricePerUnitReturnSale').val(data.d[2].Value.toFixed(2));
                             $('#txtVatReturnSale').val(data.d[3].Value.toFixed(2));
                             $('#txtSellQtyReturnSale').val(data.d[4].Value.toFixed(3));

                         },
                         error: function (result) {
                             alert('Not Match');
                         }
                     });
                 }

                 


             });
            ////////////////////////////////////
             $('#txtSaleReturnProductName').autocomplete({
                 source: function (request, response) {
                     var invoice = $('#txtSaleInvoiceNumber').val();
                     $.ajax({
                         url: "../WebServices/AutoCompleteService.asmx/SearchProductNameForSaleReturn",
                         data: "{'productname': '" + request.term + "', 'invoiceNumber': '" + invoice + "' }",
                         type: "POST",
                         dataType: "Json",
                         contentType: "application/json;charset=utf-8",
                         success: function (data) {
                             response(data.d);
                         },
                         error: function (result) {
                             alert('Not Match');
                         }
                     });
                 },
                 change: function () {
                     var invoice = $('#txtSaleInvoiceNumber').val();
                     $.ajax({
                         url: "../WebServices/AutoCompleteService.asmx/GetSaleProductNameInfo",
                         data: "{'productname': '" + this.value + "', 'invoiceNumber': '" + invoice + "' }",
                         type: "POST",
                         dataType: "json",
                         contentType: "application/json;charset=utf-8",
                         success: function (data) {
                             $('#txtSaleReturnProductCode').val(data.d[0].Value);
                             $('#txtPricePerUnitReturnSale').val(data.d[2].Value.toFixed(2));
                             $('#txtVatReturnSale').val(data.d[3].Value.toFixed(2));
                             $('#txtSellQtyReturnSale').val(data.d[4].Value.toFixed(3));

                         },
                         error: function (result) {
                             alert('Not Match2');
                         }
                     });
                 }




             });




       });

</script>
</asp:Content>
