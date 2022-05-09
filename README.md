<h1>香川大学Moodleカレンダー通知アプリ</h1>
香川大学Moodleからカレンダー情報を取得。今日の予定を通知します。

アプリに一度ログイン情報を登録するだけで、毎日0時過ぎに今日の予定を通知してくれます。
スマホを再起動しても（その後アプリを開かずとも）通知は続きます。

<h2>ダウンロード</h2>
ダウンロード及びアップデートは以下から可能です。

<a href='https://play.google.com/store/apps/details?id=tech.taksas.k_moodlenotifier&pcampaignid=pcampaignidMKT-Other-global-all-co-prtnr-py-PartBadge-Mar2515-1'><img width="200px" alt='Google Play で手に入れよう' src='https://play.google.com/intl/ja/badges/static/images/badges/ja_badge_web_generic.png'/></a>

<h2>利用時の注意</h2>
・ 当日のカレンダーに手動で予定が追加されていた場合、通知の表示がバグります。このアプリを使用する場合は予定の手動追加はお控えください。
<br>
・ 「電池の最適化」機能は必ず除外設定をしてください。（アプリの起動時の指示に従うことで設定が可能です）
<br>
・Huawei製スマホなど、一部のスマホにはメーカー独自の省電力機能が搭載されています。そういった機能においても除外設定を推奨します。
<h2>バッテリー周りで特に注意すべきスマホ</h2>
一部のスマホでは、省電力化のために過剰なタスクキル機能が存在します。
<br>
・Galaxy（特にAndroid9以降）
<br>
・OnePlus
<br>
・Huawei
<br>
の3社については、メーカー固有の除外設定をしない、デフォルト状態ではほぼ確実にアプリが動作しません。これらのメーカーはAndroid標準のバックグラウンド処理の扱いと大きく乖離した省電力機能を搭載しています。
<br>
・Xiaomi
<br>
・Asus
<br>
この2社についても、除外設定無しでは正常に動かない可能性があります。
<br>
・Lenovo
<br>
・Oppo
<br>
・Vivo
<br>
この3社については高確率で正常に動作すると思われますが、Android標準よりも強力な省電力機能を有しています。
<br>
・Sony
<br>
ソニーのXperiaシリーズについては、Android標準に限りなく近い仕様の省電力機能を有しています。
<br>
・AOSP
<br>
・HTC
<br>
Android標準の省電力機能の仕様であれば、このアプリは間違いなく正常に動作します。
<br>
<br>
スマホのバッテリーセーバー機能やデータセーバー機能がオンの場合、より動作しない可能性が高まります。
<br>
<h2>免責事項</h2>
このアプリの利用は全て自己責任です。開発者はこのアプリの使用によって生じたあらゆる損害（通知が来なくて課題提出を忘れたなど）を補償しません。

<h2>マルチプラットフォームについて</h2>
このプロジェクトの開発環境、Xamarin.Forms自体はマルチプラットフォーム（Android, iOS, UWP(β)）対応です。
が、このプロジェクトでは各プラットフォーム依存のサービス（ローカル通知とバックグラウンド処理）を使用しており、Xamarin.Forms の DependencyServiceを用いて実装しています。
この各プラットフォーム依存のサービスについては現状Android向けのものしか実装していないため、現在のリリースターゲットはAndroidのみになっています。

<h2>フォークとプルリクエスト</h2>
iOS用のDependency Serviceを実装するなど大歓迎です（当方Macを持っていないためiOSアプリ開発が出来ませぬ）。

<h2>ライセンス</h2>
ライセンスの詳細については、

[LICENSEファイル](https://github.com/taksas/K-MoodleNotifier/blob/master/LICENSE) 
<br>
を参照してください。
<br>
このプロジェクトはMITライセンスでの公開となります。
