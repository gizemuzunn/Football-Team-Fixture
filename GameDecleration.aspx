<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GameDecleration.aspx.cs" Inherits="GameDeclerat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Game Decleration</title>
    <link href="StyleSheet.css" rel="stylesheet" />
    <script type="text/javascript">
        function openModal() {
            $('#exampleModal').modal('show');
        }
    </script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="baslik">
                <div class="baslik2">
                    <div class="baslik4">
                        <img src="footballlogo.jpg" class="imgg"/>
                     </div>

                    
                    <div class="baslik3">
                        <p class="yazi">Wellcome To Football Season<p>
                        <p class="yazi2">Football Season 2019-2020<p>
                     </div>
                    
                </div>
            </div>
        <div class="container">
            
            <asp:Panel ID="Panel1" runat="server">
                <div class="card">
                    <div class="card-header bg-primary text-light">
                        Start New Season
                    </div>
                    <div class="card-body">

                        <table class="table table-striped">
                            <thead>
                                <tr>
                                    <th scope="col">#</th>
                                    <th scope="col">Team Name</th>
                                    <th scope="col">Discription</th>

                                </tr>
                            </thead>
                            <tbody>
                                <tr id="Tr1" runat="server">
                                    <th scope="row">1</th>
                                    <td>
                                        <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                    <td>
                                        <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                </tr>
                                <tr id="Tr2" runat="server">
                                    <th scope="row">2</th>
                                    <td>
                                        <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                    <td>
                                        <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                </tr>
                                <tr id="Tr3" runat="server">
                                    <th scope="row">3</th>
                                    <td>
                                        <asp:TextBox ID="TextBox5" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                    <td>
                                        <asp:TextBox ID="TextBox6" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                </tr>
                                <tr id="Tr4" runat="server">
                                    <th scope="row">4</th>
                                    <td>
                                        <asp:TextBox ID="TextBox7" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                    <td>
                                        <asp:TextBox ID="TextBox8" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                </tr>
                                <tr id="Tr5" runat="server">
                                    <th scope="row">5</th>
                                    <td>
                                        <asp:TextBox ID="TextBox9" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                    <td>
                                        <asp:TextBox ID="TextBox10" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                </tr>
                                <tr id="Tr6" runat="server">
                                    <th scope="row">6</th>
                                    <td>
                                        <asp:TextBox ID="TextBox11" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                    <td>
                                        <asp:TextBox ID="TextBox12" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                </tr>
                                <tr id="Tr7" runat="server">
                                    <th scope="row">7</th>
                                    <td>
                                        <asp:TextBox ID="TextBox13" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                    <td>
                                        <asp:TextBox ID="TextBox14" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                </tr>
                                <tr id="Tr8" runat="server">
                                    <th scope="row">8</th>
                                    <td>
                                        <asp:TextBox ID="TextBox15" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                    <td>
                                        <asp:TextBox ID="TextBox16" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                </tr>
                                <tr id="Tr9" runat="server">
                                    <th scope="row">9</th>
                                    <td>
                                        <asp:TextBox ID="TextBox17" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                    <td>
                                        <asp:TextBox ID="TextBox18" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                </tr>
                                <tr id="Tr10" runat="server">
                                    <th scope="row">10</th>
                                    <td>
                                        <asp:TextBox ID="TextBox19" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                    <td>
                                        <asp:TextBox ID="TextBox20" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                </tr>
                                <tr id="Tr11" runat="server">
                                    <th scope="row">11</th>
                                    <td>
                                        <asp:TextBox ID="TextBox21" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                    <td>
                                        <asp:TextBox ID="TextBox22" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                </tr>
                                <tr id="Tr12" runat="server">
                                    <th scope="row">12</th>
                                    <td>
                                        <asp:TextBox ID="TextBox23" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                    <td>
                                        <asp:TextBox ID="TextBox24" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                </tr>
                                <tr id="Tr13" runat="server">
                                    <th scope="row">13</th>
                                    <td>
                                        <asp:TextBox ID="TextBox25" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                    <td>
                                        <asp:TextBox ID="TextBox26" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                </tr>
                                <tr id="Tr14" runat="server">
                                    <th scope="row">14</th>
                                    <td>
                                        <asp:TextBox ID="TextBox27" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                    <td>
                                        <asp:TextBox ID="TextBox28" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                </tr>
                                <tr id="Tr15" runat="server">
                                    <th scope="row">15</th>
                                    <td>
                                        <asp:TextBox ID="TextBox29" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                    <td>
                                        <asp:TextBox ID="TextBox30" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                </tr>
                                <tr id="Tr16" runat="server">
                                    <th scope="row">16</th>
                                    <td>
                                        <asp:TextBox ID="TextBox31" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                    <td>
                                        <asp:TextBox ID="TextBox32" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                </tr>
                                <tr id="Tr17" runat="server">
                                    <th scope="row">17</th>
                                    <td>
                                        <asp:TextBox ID="TextBox33" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                    <td>
                                        <asp:TextBox ID="TextBox34" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                </tr>
                                <tr id="Tr18" runat="server">
                                    <th scope="row">18</th>
                                    <td>
                                        <asp:TextBox ID="TextBox35" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                    <td>
                                        <asp:TextBox ID="TextBox36" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                </tr>
                                <tr id="Tr19" runat="server">
                                    <th scope="row">19</th>
                                    <td>
                                        <asp:TextBox ID="TextBox37" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                    <td>
                                        <asp:TextBox ID="TextBox38" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                </tr>
                                <tr id="Tr20" runat="server">
                                    <th scope="row">20</th>
                                    <td>
                                        <asp:TextBox ID="TextBox39" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                    <td>
                                        <asp:TextBox ID="TextBox40" CssClass="form-control" runat="server" Width="300px"></asp:TextBox></td>
                                </tr>


                            </tbody>
                        </table>

                    </div>
                </div>



                <asp:Button ID="Button5" CssClass="btn btn-primary" runat="server" Text="Back" OnClick="Button5_Click2" />
                <asp:Button ID="Button6" CssClass="btn btn-primary" runat="server" Text="Save/Update Team Info" data-toggle="modal" data-target="#exampleModal" OnClick="Button6_Click" />
                <asp:Button ID="Button7" CssClass="btn btn-primary" runat="server" Text="Go Next Page" OnClick="Button7_Click" />
                <br />



            </asp:Panel>





            <%-- Modal--%>
            <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLabel">Save Team Info Confirmation</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            You are about to save team info to the database !</br>
        Do you want to continue ? 
                        </div>
                        <div class="modal-footer">
                            <asp:Button ID="Button3" CssClass="btn btn-secondary" runat="server" Text="Close" />
                            <asp:Button ID="Button4" CssClass="btn btn-primary" runat="server" Text="Yes! Go On" OnClick="Button8_Click" />
                        </div>
                    </div>
                </div>
            </div>
            <%--END MODEL--%>
        </div>

        <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
        <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
        <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>

    </form>
</body>
</html>
