<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="demonstraionusercontrols.WebUserControl1" %>
<section id="main-content">
    <section class="wrapper">
        <div class="row">
            <div class="col-lg-12">
                <section class="pannel">
                    <header class="pannel-heading">
                        <div class="col-md-4 col-md-offset-4">
                            <h1>Registration form</h1>
                        </div>
                    </header>
                    <div class="panel-body">
                        <div class="row">
                            <div class="col-md-4 col-md-offset-1">
                                <div class="form-group">
                                    <asp:Label runat="server" AssociatedControlID="txtempname"><b>Employee Name</b></asp:Label>
                                    <asp:TextBox runat="server" required="required" Enabled="true" name="BrandName" ID="txtempname" class="form-control input-sm" placeholder="Employee Name"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-4 col-md-offset-1">
                                <div class="form-group">
                                    <asp:Label runat="server" AssociatedControlID="txtemployeeno"><b>Employee ID</b></asp:Label>
                                    <asp:TextBox runat="server" required="required" Enabled="true" name="BrandName" ID="txtemployeeno" class="form-control input-sm" placeholder="Employee ID"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4 col-md-offset-1">
                                <div class="form-group">
                                    <asp:Label runat="server" AssociatedControlID="txtdob"><b>DOB</b></asp:Label>
                                    <asp:TextBox runat="server" TextMode="Date" required="required" Enabled="true" name="BrandName" ID="txtdob" class="form-control input-sm"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-4 col-md-offset-1">
                                <div class="form-group">
                                    <asp:Label runat="server" AssociatedControlID="txtdpt"><b>Department</b></asp:Label>
                                    <asp:TextBox runat="server" required="required" Enabled="true" name="BrandName" ID="txtdpt" class="form-control input-sm" placeholder="Department"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4 col-md-offset-1">
                                <div class="form-group">
                                    <asp:Label runat="server" AssociatedControlID="txtcountry"><b>Country</b></asp:Label>
                                    <asp:DropDownList ID="txtcountry" CssClass="form-control input-input-sm" runat="server">
                                        <asp:ListItem Text="India" />
                                        <asp:ListItem Text="Pakistan" />
                                        <asp:ListItem Text="China" />
                                        <asp:ListItem Text="Nepal" />
                                        <asp:ListItem Text="Sri Lanka" />
                                        <asp:ListItem Text="Bangladesh" />
                                    </asp:DropDownList>
                                </div>
                            </div>

                            <div class="col-md-4 col-md-offset-1">
                                <div class="form-group">
                                    <asp:Label runat="server" AssociatedControlID="txtaddress"><b>Address</b></asp:Label>
                                    <asp:TextBox runat="server" required="required" Enabled="true" name="BrandName" ID="txtaddress" class="form-control input-sm" placeholder="Address"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4 col-md-offset-1">
                                <div class="form-group">
                                    <asp:Label runat="server" AssociatedControlID="txtcontact"><b>Contact No</b></asp:Label>
                                    <asp:TextBox runat="server" TextMode="Number" required="required" Enabled="true" name="BrandName" ID="txtcontact" class="form-control input-sm" placeholder="Conact No"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-4 col-md-offset-1">
                                <div class="form-group">
                                    <asp:Label runat="server" AssociatedControlID="txtgender"><b>Department</b></asp:Label>
                                    <asp:RadioButtonList CssClass="form-group" ID="txtgender" runat="server">
                                        <asp:ListItem Text="Male" />
                                        <asp:ListItem Text="Famle" />
                                        <asp:ListItem Text="Other" />
                                    </asp:RadioButtonList>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-8 col-md-offset-2">
                                <asp:Button Text="Save" ID="btnsave" CssClass="btn btn-primary" runat="server" />
                            </div>
                        </div>
                    </div>
                </section>
            </div>
        </div>
    </section>
</section>
