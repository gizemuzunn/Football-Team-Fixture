<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LastSeason.aspx.cs" Inherits="LastSeason" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Page</title>

    <script type="text/javascript">
        function openModal() {
            $('#exampleModal').modal('show');
        }
    </script>

    <link href="StyleSheet.css" rel="stylesheet" />
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
                        <asp:GridView ID="GridView1" CssClass="table table-bordered table-striped table-responsive" runat="server"></asp:GridView>
                    </div>
                </div>
            </asp:Panel>

            <%-- Modal--%>
            <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLabel">Create new Season</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            You are about to create new season !</br>
        Do you want to continue ? 
                        </div>
                        <div class="modal-footer">
                            <asp:Button ID="Button3" CssClass="btn btn-secondary" runat="server" Text="Close" />
                            <asp:Button ID="Button4" CssClass="btn btn-primary" runat="server" Text="Yes! Go On"/>
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
