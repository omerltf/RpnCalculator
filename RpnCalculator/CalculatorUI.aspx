<%@ Page Title="" Language="C#" MasterPageFile="~/RpnCalculator.Master" AutoEventWireup="true" CodeBehind="CalculatorUI.aspx.cs" Inherits="RpnCalculator.CalculatorUI" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <h1>RPN Calculator</h1>
    <div>
        <asp:Repeater ID="StackViewer" ItemType="System.String" runat="server">
            <HeaderTemplate>
                <table>
            </HeaderTemplate>

            <ItemTemplate>
                <tr>
                    <td>
                        <asp:Label ID="NumberDisplay" Text='<%# Item %>' runat="server" />
                    </td>
                </tr>
            </ItemTemplate>

            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    </div>

    <section>
        <asp:TextBox ID="NumberInput" runat="server" />
        <asp:Button ID="Enter" Text="Enter" OnClick="HandleEnter" runat="server" />
    </section>

    <fieldset>
        <legend>Math Operations</legend>
        <asp:Button ID="Add" Text="+" OnClick="HandleAdd" runat="server" />
        <asp:Button ID="Minus" Text="-" OnClick="HandleMinus" runat="server" />
        <asp:Button ID="Multiply" Text="*" OnClick="HandleMultiply" runat="server" />
        <asp:Button ID="Divide" Text="/" OnClick="HandleDivide" runat="server" />
        <asp:Button ID="Negate" Text="(-)" OnClick="HandleNegate" runat="server" />
        <asp:Button ID="SquareRoot" Text="sqrt" OnClick="HandleSquareRoot" Visible="true" runat="server" />
        <asp:Button ID="EtoX" Text="e^x" OnClick="HandleEtoX" Visible="true" runat="server" />
        <asp:Button ID="YtoX" Text="y^x" OnClick="HandleYtoX" Visible="true" runat="server" />
        <asp:Button ID="Reciprocal" Text="1/x" OnClick="HandleReciprocal" Visible="true" runat="server" />
        <asp:Button ID="SinX" Text="sin(x)" OnClick="HandleSinX" Visible="true" runat="server" />
        <asp:Button ID="CosX" Text="cos(x)" OnClick="HandleCosX" Visible="true" runat="server" />
    </fieldset>

    <fieldset>
        <legend>Stack Operations</legend>
        <asp:Button ID="Drop" Text="Drop" OnClick="HandleDrop" runat="server" />
        <asp:Button ID="Clear" Text="Clear" OnClick="HandleClear" Visible="true" runat="server" />
        <asp:Button ID="Swap" Text="Swap" OnClick="HandleSwap" Visible="true" runat="server" />
        <asp:Button ID="Rotate" Text="Rotate" OnClick="HandleRotate" Visible="true" runat="server" />
    </fieldset>
</asp:Content>
