<h1>香川大学Moodleカレンダー通知アプリ</h1>
香川大学Moodleからカレンダー情報を取得。今日の予定を通知します。

アプリに一度ログイン情報を登録するだけで、毎日0時過ぎに今日の予定を通知してくれます。

<h2>ダウンロード</h2>
ダウンロード及びアップデートは以下から可能です。

<a href='https://play.google.com/store/apps/details?id=tech.taksas.k_moodlenotifier&pcampaignid=pcampaignidMKT-Other-global-all-co-prtnr-py-PartBadge-Mar2515-1'><img alt='Google Play で手に入れよう' src='https://play.google.com/intl/ja/badges/static/images/badges/ja_badge_web_generic.png'/></a>

<h2>利用時の注意</h2>
・ 当日のカレンダーに手動で予定が追加されていた場合、通知の表示がバグります。このアプリを使用する場合は予定の手動追加はお控えください。
<br>
・ 「電池の最適化」機能は必ず除外設定をしてください。（アプリの起動時の指示に従うことで設定が可能です）
・Huawei製スマホなど、一部のスマホにはメーカー独自の省電力機能が搭載されています。そういった機能においても除外設定を推奨します。

<h2>マルチプラットフォームについて</h2>
このプロジェクトの開発環境、Xamarin.Forms自体はマルチプラットフォーム（Android, iOS, UWP(β)）対応です。
が、このプロジェクトでは各プラットフォーム依存のサービス（ローカル通知とバックグラウンド処理）を使用しており、Xamarin.Forms の DependencyServiceを用いて実装しています。
この各プラットフォーム依存のサービスについては現状Android向けのものしか実装していないため、現在のリリースターゲットはAndroidのみになっています。

<h2>ライセンス</h2>
ライセンスの詳細については、

[LICENSEファイル](https://github.com/taksas/K-MoodleNotifier/blob/master/LICENSE) 
<br>
を参照してください。
このプロジェクト自体はMITライセンスになっています。
