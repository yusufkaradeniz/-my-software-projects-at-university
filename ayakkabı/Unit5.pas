unit Unit5;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Data.DB, Data.Win.ADODB, Vcl.DBCtrls,
  Vcl.StdCtrls, Vcl.Mask, Data.Bind.Controls, Vcl.ExtCtrls, Vcl.Buttons,
  Vcl.Bind.Navigator, Data.Bind.Components, Data.Bind.DBScope, Vcl.Grids,
  Vcl.DBGrids, Vcl.ComCtrls;

type
  TForm5 = class(TForm)
    ADOConnection1: TADOConnection;
    ADOTable1: TADOTable;
    DataSource1: TDataSource;
    ADOTable2: TADOTable;
    DataSource2: TDataSource;
    DataSource3: TDataSource;
    ADOTable3: TADOTable;
    DBGrid1: TDBGrid;
    PageControl1: TPageControl;
    TabSheet2: TTabSheet;
    GroupBox3: TGroupBox;
    Label13: TLabel;
    Label14: TLabel;
    Label15: TLabel;
    Label16: TLabel;
    Label17: TLabel;
    Label18: TLabel;
    Label19: TLabel;
    DBEdit15: TDBEdit;
    DBEdit16: TDBEdit;
    DBEdit17: TDBEdit;
    DBEdit18: TDBEdit;
    DBEdit19: TDBEdit;
    DBImage1: TDBImage;
    DBEdit20: TDBEdit;
    DBEdit21: TDBEdit;
    DBEdit22: TDBEdit;
    TabSheet3: TTabSheet;
    Label3: TLabel;
    DBEdit3: TDBEdit;
    Label5: TLabel;
    Label6: TLabel;
    Label9: TLabel;
    Label11: TLabel;
    Label12: TLabel;
    Label20: TLabel;
    Label21: TLabel;
    Label22: TLabel;
    DBEdit5: TDBEdit;
    DBEdit6: TDBEdit;
    DBEdit11: TDBEdit;
    DBEdit12: TDBEdit;
    DBEdit13: TDBEdit;
    DBEdit14: TDBEdit;
    DBEdit23: TDBEdit;
    DBEdit24: TDBEdit;
    DBNavigator1: TDBNavigator;
    DBGrid2: TDBGrid;
    Edit1: TEdit;
    Label1: TLabel;
    Button1: TButton;
    Button2: TButton;
    Button3: TButton;
    Button4: TButton;
    Button5: TButton;
    Button9: TButton;
    Button10: TButton;
    Button11: TButton;
    procedure ADOTable2FilterRecord(DataSet: TDataSet; var Accept: Boolean);
    procedure Edit1Change(Sender: TObject);
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure Button5Click(Sender: TObject);
    procedure Button11Click(Sender: TObject);
    procedure Button10Click(Sender: TObject);
    procedure Button9Click(Sender: TObject);
    procedure Button8Click(Sender: TObject);
    procedure Button7Click(Sender: TObject);
    procedure Button4Click(Sender: TObject);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form5: TForm5;

implementation

{$R *.dfm}

procedure TForm5.ADOTable2FilterRecord(DataSet: TDataSet; var Accept: Boolean);
var s : String;
begin
       s:= Edit1.Text;
    if AnsiUpperCase (s)=AnsiUpperCase(Copy(ADOTable2.FieldByName('KullanýcýAdý').AsString,1,s.Length)) then
    Accept:=True
    else Accept:=False;

end;

procedure TForm5.Button10Click(Sender: TObject);
begin
      AdoTable1.Edit;
AdoTable1.Post;
end;

procedure TForm5.Button11Click(Sender: TObject);
begin
Groupbox3.SetFocus;
AdoTable1.Insert;
end;

procedure TForm5.Button1Click(Sender: TObject);
begin
DBGrid2.SetFocus;
AdoTable3.Insert;
end;

procedure TForm5.Button2Click(Sender: TObject);
begin
AdoTable3.Edit;
AdoTable3.Post;
end;

procedure TForm5.Button3Click(Sender: TObject);
begin
AdoTable3.Delete;
end;

procedure TForm5.Button4Click(Sender: TObject);
begin
  AdoTable3.Next ;
end;

procedure TForm5.Button5Click(Sender: TObject);
begin
      AdoTable3.Prior ;
end;

procedure TForm5.Button7Click(Sender: TObject);
begin
AdoTable1.Prior ;
end;

procedure TForm5.Button8Click(Sender: TObject);
begin

   AdoTable1.Next ;
end;

procedure TForm5.Button9Click(Sender: TObject);
begin
  AdoTable1.Delete;
end;

procedure TForm5.Edit1Change(Sender: TObject);
begin
  AdoTable2.Filtered:=false;
      if (Edit1.Text='') then AdoTable2.Filtered:=false
      else AdoTable2.Filtered:=true;
end;

procedure TForm5.FormClose(Sender: TObject; var Action: TCloseAction);
begin

       Application.Terminate;



end;

end.
