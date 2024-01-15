# ラボ解答

新しいプロジェクトにはタイプが必要で、出力ディレクトリを設定することが望ましいです：

```
dotnet new console -o labs-signin
```

新しいプロジェクトを確認するためにフォルダをチェックしてください：

```
cd labs-signin

ls
```

すでに`Program.cs`があります。シェルツールバーの_ファイルのアップロード/ダウンロード_アイコンをクリックし、ラボフォルダから自分のファイルをアップロードしてください。

> アップロードツールは常にファイルをホームディレクトリに保存します。

次に、それを移動する必要があります：

```
mv ~/Program.cs .
```

ソースファイルをチェックし、アプリを実行してください：

```
cat Program.cs

dotnet run
```