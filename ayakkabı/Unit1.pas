unit Unit1;

interface

uses

  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.Imaging.jpeg,
  Vcl.ExtCtrls, Vcl.Imaging.pngimage;

type
  TForm1 = class(TForm)
    Button1: TButton;

    Label1: TLabel;
    Label2: TLabel;
    Edit1: TEdit;
    Edit2: TEdit;
    Image1: TImage;
    Label3: TLabel;

    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

uses Unit5, Unit2;



procedure TForm1.Button1Click(Sender: TObject);

 begin
  if (Edit1.Text='admin') and (Edit2.Text='admin') or (Edit1.Text='kullan�c�') and (Edit2.Text='kullan�c�') then
  begin
  Form2.hide;
  form1.Hide;
  Form5 :=TForm5.Create(Application);
  Form5.ShowModal ;
  Form5.Free  ;


  end
    else



    begin
         ShowMessage('Kullan�c� Ad� veya Sifre Hatal�!') ;
         Edit1.Clear;
         Edit2.Clear;

    end;


   end;

procedure TForm1.Button2Click(Sender: TObject);
begin
form2.Close ;
end;


    procedure TForm1.FormClose(Sender: TObject; var Action: TCloseAction);
begin
Application.Terminate;

end;

end.
