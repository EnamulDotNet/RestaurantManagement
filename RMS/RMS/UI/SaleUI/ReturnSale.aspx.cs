﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RMS.BLL;
using RMS.DAL;
using RMS.Model;

namespace RMS.UI.SaleUI
{
    public partial class ReturnSale : BasePage
    {
        private decimal tot;
        protected void Page_Load(object sender, EventArgs e)
        {
            txtSaleReturnGrandTotal.Attributes.Add("readonly", "readonly");
            txtDiscount.Attributes.Add("readonly", "readonly");
            txtPaidAmount.Attributes.Add("readonly", "readonly");
            txtCustomerUsername.Attributes.Add("readonly", "readonly");
            txtCustomerFullName.Attributes.Add("readonly", "readonly");
            txtDueByThisInvoice.Attributes.Add("readonly", "readonly");
            txtTotalDue.Attributes.Add("readonly", "readonly");

            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[6]
                {
                    new DataColumn("ProductId"), new DataColumn("ProductName"), new DataColumn("ProductQty"),
                    new DataColumn("ProductPricePerUnit"), new DataColumn("ProductVat"), new DataColumn("ProductTotalPrice")
                });
                Session["ReturnSellProduct"] = dt;
                this.GridviewBind();
            }
        }

        protected void GvReturnSell_OnRowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                try
                {
                    tot += Convert.ToDecimal(DataBinder.Eval(e.Row.DataItem, "ProductTotalPrice"));

                }
                catch
                {
                    // ignored
                }
            }
            else if (e.Row.RowType == DataControlRowType.Footer)
            {
                e.Row.Cells[4].Text = "Grand Total";
                e.Row.Cells[4].Font.Bold = true;

                e.Row.Cells[5].Text = tot.ToString("N2");
                e.Row.Cells[5].Font.Bold = true;
                e.Row.Cells[5].ForeColor = Color.DeepPink;
            }
        }

        protected void GvReturnSell_OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);
            DataTable dt = Session["ReturnSellProduct"] as DataTable;
            dt.Rows[index].Delete();
            Session["ReturnSellProduct"] = dt;
            GridviewBind();
            txtToBeReturnSale.Text = GvReturnSell.FooterRow.Cells[5].Text;


        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtSaleReturnQty.Text) <= Convert.ToDecimal(Request.Form[txtSellQtyReturnSale.UniqueID]))
            {
                GvReturnSell.Visible = true;
                DataTable dt = (DataTable)Session["ReturnSellProduct"];
                for (int i = 0; i < GvReturnSell.Rows.Count; i++)
                {
                    string id = GvReturnSell.Rows[i].Cells[0].Text;
                    if (id == txtSaleReturnProductCode.Text.Trim())
                    {
                        dt.Rows[i].Delete();
                        break;
                    }
                }
                dt.Rows.Add(txtSaleReturnProductCode.Text.Trim(), txtSaleReturnProductName.Text.Trim(),
                    Convert.ToDecimal(txtSaleReturnQty.Text.Trim()).ToString("N3"), Request.Form[txtPricePerUnitReturnSale.UniqueID],
                       Request.Form[txtVatReturnSale.UniqueID], Request.Form[txtTotalPricePerProductSaleReturn.UniqueID]);
                Session["ReturnSellProduct"] = dt;
                this.GridviewBind();
                txtToBeReturnSale.Text = (Convert.ToDecimal(GvReturnSell.FooterRow.Cells[5].Text)-Convert.ToDecimal(txtTotalDue.Text)).ToString("N2");
                txtSaleReturnProductCode.Text = string.Empty;
                txtSaleReturnProductName.Text = string.Empty;
                txtSaleReturnQty.Text = string.Empty;
                txtSaleReturnAmount.Text = string.Empty;
            }
            else
            {
                MessageBox("Return qty can not be greater than sell qty!");
            }
            
        }
        private void GridviewBind()
        {
            GvReturnSell.Columns[0].Visible = true;
            GvReturnSell.DataSource = (DataTable)Session["ReturnSellProduct"];
            GvReturnSell.DataBind();
            GvReturnSell.Columns[0].Visible = false;
        }
        protected void btnSaveReturn_Click(object sender, EventArgs e)
        {
            SaleReturn objSaleReturn=new SaleReturn();
            SaleReturnBiz objSaleReturnBiz=new SaleReturnBiz();
            objSaleReturn.InvoiceNumber = Convert.ToInt32(txtSaleInvoiceNumber.Text.Trim());
            objSaleReturn.CustomerUsername = txtCustomerUsername.Text;
            objSaleReturn.CreatedBy = Convert.ToInt16(Session["UserId"].ToString());
            objSaleReturn.Remarks = txtRemark.Text.Trim();
            objSaleReturn.ReturnAmount = decimal.Parse(GvReturnSell.FooterRow.Cells[5].Text)-decimal.Parse(txtReturnTotalAmount.Text);
            for (int i = 0; i < GvReturnSell.Rows.Count; i++)
            {

                objSaleReturn.ProductId = short.Parse(GvReturnSell.Rows[i].Cells[0].Text);
                objSaleReturn.ReturnQuantity = decimal.Parse(GvReturnSell.Rows[i].Cells[2].Text);
                
                objSaleReturnBiz.ReturnProduct(objSaleReturn);
                objSaleReturn.InvoiceNumber = 0;
            }
            GvReturnSell.Visible = false;
            Response.Redirect(Request.Url.ToString());
        }
    }
}