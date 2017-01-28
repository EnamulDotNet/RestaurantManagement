﻿using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using RMS.BLL;
using RMS.Model;

namespace RMS.Report.PurchaseReport
{
    public partial class SupplierwisePurchaseDetail1 : System.Web.UI.Page
    {
        private List<Supplier> objSupplierList;
        private SupplierBiz objSupplierBiz;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateDropDownForSupplier();
            }
        }

        private void PopulateDropDownForSupplier()
        {
            objSupplierList = new List<Supplier>();
            objSupplierBiz = new SupplierBiz();

            objSupplierList = objSupplierBiz.GetSupplierList();
            ddlSupplier.DataSource = objSupplierList;
            ddlSupplier.DataValueField = "SupplierId";
            ddlSupplier.DataTextField = "SupplierName";
            ddlSupplier.DataBind();

            ddlSupplier.Items.Insert(0, new ListItem("--Select Supplier--", "0"));
        }

        protected void ddlSupplier_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            ReportDocument rdDocument = new ReportDocument();
            rdDocument.Load(Server.MapPath("SupplierwisePurchaseDetail.rpt"));
            rdDocument.SetParameterValue("@SupplierId", ddlSupplier.SelectedValue);
            CrystalReportViewer1.ReportSource = rdDocument;
            CrystalReportViewer1.EnableDatabaseLogonPrompt = false;
            CrystalReportViewer1.ToolPanelView = 0;
        }

        protected void txtInvoiceNumber_OnTextChanged(object sender, EventArgs e)
        {
            //ReportDocument rdDocument = new ReportDocument();
            //rdDocument.Load(Server.MapPath("SupplierwisePurchaseDetail.rpt"));
            ////rdDocument.SetParameterValue("@SupplierId", ddlSupplier.SelectedValue);
            //rdDocument.SetParameterValue("@InvoiceNumber", txtInvoiceNumber.Text.Trim());
            //CrystalReportViewer1.ReportSource = rdDocument;
            //CrystalReportViewer1.EnableDatabaseLogonPrompt = false;
            //CrystalReportViewer1.ToolPanelView = 0;
        }
    }
}