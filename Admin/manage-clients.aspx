<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="manage-clients.aspx.cs" Inherits="Admin_manage_clients" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-12">
                    <div class="page-title-box d-sm-flex align-items-center justify-content-between">
                        <h4 class="mb-sm-0">Clients</h4>

                        <div class="page-title-right">
                            <ol class="breadcrumb m-0">
                                <li class="breadcrumb-item"><a href="dashboard.aspx">Dashboard</a></li>
                                <li class="breadcrumb-item active"><%=Request.QueryString["id"]==null?"Add":"Update" %> Clients</li>
                            </ol>
                        </div>

                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header align-items-center d-flex">
                            <h4 class="card-title mb-0 flex-grow-1"><%=Request.QueryString["id"]==null?"Add":"Update" %> Clients</h4>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-lg-6 mb-2">
                                    <label>Client Name<sup>*</sup></label>
                                    <asp:TextBox runat="server" MaxLength="150" class="form-control mb-2 mr-sm-2" ID="txtTitle" />
                                    <asp:RequiredFieldValidator ID="req1" runat="server" ControlToValidate="txtTitle" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>  
                                <div class="col-lg-6 mb-2">
                                    <label>Image (Logo)<sup>*</sup></label>
                                    <asp:FileUpload CssClass="form-control" ID="FileUpload1" runat="server" />
                                    <small style="color: red;">Allow only .png, .jpeg, .jpg, .webp formats</small><br />
                                    <%=strImage %>
                                </div> 
                                <div class="col-lg-4 col-md-6 mb-3">
                                    <asp:Button runat="server" ID="btnSave" CssClass="btn btn-primary waves-effect waves-light m-t-25" Text="Save" ValidationGroup="Save" OnClick="btnSave_Click" />
                                    <asp:Button runat="server" ID="btnNew" CssClass="btn btn-outline-danger waves-effect waves-light m-t-25" Text="Clear All" Visible="false" OnClick="addNew_Click" />
                                    <asp:Label ID="lblThumb" runat="server" Visible="false"></asp:Label>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-12 mt-0">
                                    <p style="color: red; font-weight: bold;">Note : <sup>*</sup> are required fields</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header align-items-center d-flex">
                            <h4 class="card-title mb-0 flex-grow-1">Manage Clients</h4>
                        </div>
                        <div class="card-body">
                            <table id="alternative-pagination" class="table dt-responsive align-middle table-striped table-bordered myTable" style="width: 100%;">
                                <thead>
                                    <tr>
                                        <th>#</th>
                                        <th>Image</th>
                                        <th>Title</th>
                                        <th>Added On</th>
                                        <th class="text-center">Action</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <%=strClients %>
                                </tbody>
                            </table>
                        </div>
                    </div>

                </div>
            </div>

        </div>
    </div>
    <script src="assets/js/pages/manage-clients.js"></script>
</asp:Content>



