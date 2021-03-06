===============================================================================

　audio file to mp4

===============================================================================


■ソフトの概要

　音楽ファイルを動画ファイル(mp4)に変換するソフトです。

　任意の静止画を映像に使用します。
　(指定された１枚の画像ファイルを止め絵のように表示します)


　★当ソフトは ffmpeg を使用します。(外部コマンドとして呼び出します)
　　当ソフト使用前に ffmpeg を導入していただく必要があります。


■動作環境

　Windows 10 Pro または Windows 10 Home


■インストール方法

　アーカイブの中身をローカルディスク上の任意の場所にコピーして下さい。


■アンインストール方法

　レジストリなどは一切使っていません。
　ファイルを削除するだけでアンインストールできます。


■ffmpeg導入方法

　1. ブラウザから https://ffmpeg.org/ を開いて下さい。

　2. ページ左側のメニューの Download をクリックして下さい。

　3. Get the packages の Windows のロゴにカーソルを合わせ、
　   Windows Packages の Windows Builds をクリックして下さい。

　4. Version の 4.1.3 を選択して下さい。

　　★バージョン番号が更新されている場合は Previous Builds からダウンロードして下さい。
　　　最新版で代替することも可能ですが、当ソフトが正常に動作しないかもしれません。

　5. Architecture の 32-bit または 64-bit を「導入環境に合わせて」選択して下さい。
　   よくわからない場合は 32-bit を選択して下さい。

　6. Linking の Shared を選択して下さい。(Static でも OK です)

　7. Download Build をクリックして .zip ファイルをダウンロードして下さい。

　8. ダウンロードした .zip を任意の場所に展開して下さい。
　   展開先のパスは後で使用するので、覚えておいて下さい。


　★この手順は 2019/7/8 に作成しました。

　★開発・テスト環境では ffmpeg-4.1.3-win64-shared.zip を使用しています。

　★開発・テスト環境では C:\app\ffmpeg-4.1.3-win64-shared に展開しました。


■起動方法

　audiofile2mp4.exe を実行して下さい。


■チュートリアル

　1. 上部メニューの 設定 / ffmpegの場所 をクリックして下さい。

　2. [...] を押して、ffmpegのフォルダを選択し、[OK] を押して下さい。

　   ★ffmpegのフォルダとは "ffmpeg導入方法" においてffmpegを展開したフォルダのことです。

　3. [OK] を押して "ffmpegのフォルダ選択ダイアログ" を閉じて下さい。

　4. 上部メニューの 設定 / 出力先 をクリックして下さい。

　5. [...] を押して、出力先フォルダを(作成)選択し、[OK] を押して下さい。

　6. [OK] を押して "出力先フォルダ選択ダイアログ" を閉じて下さい。

　～～～ここまでは初回起動時のみ行って下さい～～～

　7. 音楽ファイルまたは音楽ファイルの入ったフォルダを、ウィンドウの中央あたりにドラッグアンドドロップして下さい。(複数でも可)
　   音楽ファイルがテーブルに登録されます。

　8. 画像ファイルを、ウィンドウの中央あたりにドラッグアンドドロップして下さい。(複数でも可)
　   音楽ファイルに映像用の画像が登録されます。

　   ★画像は現在選択中の行に登録されます。
　   　画像を個別に登録するには、行選択と画像ファイルのドラッグアンドドロップを個別に行って下さい。

　9. 上部メニューの コンバータ / 開始 をクリックして下さい。

　10. 右下のステータスの 待機中, 処理中 が共に 0 になるまでお待ち下さい。

　    ★途中で当ソフトを終了したい場合は、上部メニューの コンバータ / 停止 をクリックしてから [×] を押して下さい。

　11. (5.) で選択した出力先フォルダを確認し、動画ファイルが出力されていれば成功です。


■音楽ファイルについて

　拡張子が .aac .aif .mp3 .mp4 .wav .wma のファイルを音楽ファイルと見なします。


　★これら以外の拡張子でも ffmpeg が処理出来る形式であれば対応しているはずです。
　　拡張子は audio_extensions.txt に定義されているので必要があれば適宜編集して下さい。
　　ファイルの編集は当ソフトを終了してから行って下さい。
　　ファイルのエンコーディングは US-ASCII, 改行コードは LF 又は CR-LF です。拡張子は改行区切りで記述して下さい。


■画像ファイルについて

　拡張子が .bmp .gif .jpg .jpeg .png のファイルを画像ファイルと見なします。


■画面の説明

　●上部メニュー

　　アプリ / 終了

　　　当ソフトを終了します。

　　設定 / ffmpegの場所

　　　ffmpegを展開したフォルダを指定します。

　　設定 / 出力先

　　　生成した動画ファイルの出力先フォルダを指定します。

　　設定 / デフォルト の 映像用の画像

　　　音楽ファイルを登録したとき、デフォルトで設定される "映像用の画像" (画像ファイル) を指定します。

　　設定 / その他の設定

　　　詳細設定を行います。後述の "●設定" を参照して下さい。

　　コンバータ / 開始

　　　動画ファイルの生成を開始します。
　　　コンバータ実行中は、ステータスが空 (待機中) の行について順次処理します。

　　　★エラーになった行を再処理したい場合は、
　　　　右クリックメニューの "エラーになった行のステータスを解除" をクリックしてから
　　　　コンバータを開始して下さい。

　　コンバータ / 停止

　　　動画ファイルの生成を停止します。
　　　コンバータを停止しても「現在処理中の行」は停止しません。停止するまでお待ち下さい。


　●右クリックメニュー

　　選択解除

　　　全ての行の選択を解除します。

　　全て選択する

　　　全ての行を選択状態にします。

　　選択 / 待機中のファイル

　　　ステータスが空 (待機中) の行のみ選択状態にします。

　　選択 / エラーになったファイル

　　　ステータスが "エラー" の行のみ選択状態にします。

　　選択 / 成功したファイル

　　　ステータスが "処理成功" の行のみ選択状態にします。

　　選択行を削除

　　　選択行のみテーブルから削除します。
　　　ファイルは削除されません。

　　全ての行を削除

　　　テーブルを空にします。
　　　ファイルは削除されません。

　　選択行のステータスを解除

　　　選択行のみステータスを空 (待機中) に変更します。
　　　処理中の行は変更出来ません。

　　エラーになった行のステータスを解除

　　　ステータスが "エラー" の行のみステータスを空 (待機中) にします。

　　全ての行のステータスを解除

　　　全ての行のステータスを空 (待機中) にします。

　　リフレッシュ

　　　画面を更新します。

　　映像用の画像を設定する

　　　選択行の "映像用の画像" を指定します。

　　秒間フレーム数を設定する

　　　選択行の "FPS" を指定します。


　●設定

　　基本 / フルパスで表示 / 音楽ファイルをフルパスで表示する

　　　チェックを入れると "音楽ファイル (入力)" 列をフルパスで表示します。

　　基本 / フルパスで表示 / 画像ファイルをフルパスで表示する

　　　チェックを入れると "映像用の画像 (入力)" 列をフルパスで表示します。

　　基本 / フルパスで表示 / 動画ファイルをフルパスで表示する

　　　チェックを入れると "動画ファイル (出力)" 列をフルパスで表示します。

　　基本 / デフォルトFPS

　　　音楽ファイルを登録したとき、デフォルトで設定される "FPS" を指定します。

　　基本 / 動画ファイル (出力先) の上書きを許可する

　　　チェックを入れると、出力先フォルダに動画ファイルを出力するとき、しれっと上書きします。

　　基本 / 音楽ファイルを重複して登録出来ないようにする

　　　チェックを入れると、既に登録されている音楽ファイルを登録しようとすると、しれっと無視します。

　　基本 / [×]ボタン押下でコンバータを停止する。

　　　チェックを入れると、当ソフトを終了させる操作を行ったとき、
　　　コンバータ実行中であれば コンバータ / 停止 をクリックする動作を勝手に行います。

　　基本 / 半角ピリオドで始まるファイルを無視する。

　　　チェックを入れると、ローカルファイル名が '.' で始まる音楽ファイルを登録しようとすると、しれっと無視します。
　　　マッキントッシュのファイルシステム対策です。

　　二重に表示 / 画像を二重に表示する

　　　画像のアスペクト比がそのまま映像のアスペクト比になるため、
　　　再生画面のアスペクト比と異なる場合、ほとんどの動画プレイヤでは余白の部分が真っ黒になります。
　　　当項目にチェックを入れると、この真っ黒な部分にも画像を表示するようにします。(この画像を "裏側の画像" と呼びます)

　　二重に表示 / 画面サイズ

　　　動画を再生する環境の画面サイズを指定して下さい。
　　　高さ 幅 共に偶数でなければなりません。

　　二重に表示 / ぼかし

　　　裏側の画像のぼかし強度を指定して下さい。
　　　値が大きいほど強くぼかします。ぼかしを入れない場合は 0 を指定して下さい。

　　二重に表示 / 明るさ

　　　裏側の画像の明るさを指定して下さい。
　　　値が小さいほど暗くなります。一切暗くしない場合は 100 を指定して下さい。

　　その他 / 音量調整 - 音量の均一化を行う (テスト実装)

　　　音源の違い等による音量の不均衡を解消します。
　　　これはテスト的に実装した機能です。

　　その他 / 音楽ファイルと同名の画像ファイルを映像に使用する

　　　音楽ファイルのドラッグアンドドロップ時、音楽ファイルと「同名」の画像ファイルがあれば、
　　　それを "映像用の画像" として登録します。

　　　★同名とは、パスの拡張子以外の部分が大文字小文字を区別せずに同じ文字列であることを指します。


■FPSについて

　映像の秒間フレーム数 (コマ数) です。
　止め絵なので低い方が良いのですが、
　低すぎると動画プレイヤによって正常に再生できないことがあるようです。
　FPS = 1, 2 は vlc 等での再生に問題があったので、FPS = 3 をデフォルトにしています。
　それでも問題がある場合は FPS = 20 くらいまで上げてみて下さい。(FPS = 20 はよく見かけるので一般的なのかなと...)


■ドラッグアンドドロップについて

　ファイル・フォルダをドラッグアンドドロップすると以下の動作を行います。

　1. ドロップされた全てのファイルとフォルダの配下の全てのファイルを処理対象とします。

　2. 音楽ファイルがあれば、それらを登録します。

　3. 音楽ファイルが無かった場合、画像ファイルがあれば、それらを "映像用の画像" として登録します。


■補足

　ログファイル audiofile2mp4.log, audiofile2mp4.log0 は、合計およそ 2 MB を超えないように管理 (自動的に削除) されます。


■取り扱い種別

　フリーソフト


■作者への連絡先

　stackprobes@gmail.com

　不具合や要望など気軽にご連絡下さい。

