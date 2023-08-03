program Project7;

uses
  Vcl.Forms,
  Unit5 in 'Unit5.pas' {Form5},
  Unit1 in 'Unit1.pas' {Form1},
  Vcl.Themes,
  Vcl.Styles,
  Unit2 in 'Unit2.pas' {Form2};

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  TStyleManager.TrySetStyle('Onyx Blue');
  Application.CreateForm(TForm2, Form2);
  Application.CreateForm(TForm1, Form1);
  Application.CreateForm(TForm5, Form5);
  Application.Run;
end.
