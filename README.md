# Asterism

Asterismは、XYZデータおよびZマップデータの可視化・解析を行うWindowsアプリケーションです。

実験データや数値解析結果など、大量のCSVファイルを、高速で目視チェックするためのツールとして設計されています。

## 機能

- XYZ点群データの読み込みと表示
- Zマップ（高さマップ）データの可視化
- データの回転・変換処理
- グラフ表示とヒートマップ生成
- ファイル管理機能

## 必要要件

- .NET Framework 4.5.1以上
- Windows OS

## プロジェクト構造

```
asterism/
├── src/
│   └── Asterism/           # メインプロジェクト
│       ├── Forms/          # フォームクラス
│       ├── Properties/     # アセンブリ情報とリソース
│       ├── DLL/            # 外部ライブラリ
│       ├── Config.cs       # 設定クラス
│       ├── Core.cs         # コア機能
│       └── Program.cs      # エントリポイント
├── samples/                # サンプルデータファイル
├── docs/                   # ドキュメント
├── bin/                    # ビルド出力
└── obj/                    # 中間ビルドファイル
```

## ビルド方法

Visual Studio 2010以降で `Asterism.sln` を開き、ビルドしてください。

または、コマンドラインから：

```bash
msbuild Asterism.sln /p:Configuration=Release
```

## 使用ライブラリ

- **WeifenLuo.WinFormsUI.Docking** - ドッキングウィンドウUI
- **ZedGraph** - グラフ描画
- **CodeD.Data.XYZData** - XYZデータ処理
- **CodeD.Data.ZMappingData** - Zマッピングデータ処理

## ライセンス

このプロジェクトのライセンスについては、ライセンスファイルを参照してください。

## 更新履歴

詳細は [RevisionHistory.txt](docs/RevisionHistory.txt) を参照してください。

## 作者

dck-jp

## 関連プロジェクト

- [CodeD.CSV2Heatmap](https://github.com/dck-jp/CodeD.CSV2Heatmap) - CSV形式の2DマップデータからヒートマップBMP画像を生成する.NETライブラリ
