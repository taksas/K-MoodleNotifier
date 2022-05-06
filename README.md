<h1>香川大学Moodleカレンダー通知アプリ</h1>
<h2>香川大学Moodleからカレンダー情報を取得。今日の予定を通知します</h2>

アプリに一度ログイン情報を登録するだけで、毎日0時過ぎに今日の予定を通知してくれます。

<h1>ダウンロード</h1>
ダウンロード及びアップデートは以下から可能です。

[GitHhb上でリリースを見る](https://github.com/taksas/ZoomMuter/tags)

<h1>マルチプラットフォームについて</h1>
このプロジェクトの開発環境、Xamarin.Forms自体はマルチプラットフォーム（Android, iOS, UWP(β)）対応です。
が、このプロジェクトでは各プラットフォーム依存のサービス（ローカル通知とバックグラウンド処理）を使用しており、Xamarin.Forms の DependencyServiceを用いて実装しています。
この各プラットフォーム依存のサービスについては現状Android向けのものしか実装していないため、現在のリリースターゲットはAndroidのみになっています。
<h1>ライセンス</h1>
ライセンスの詳細については、[LICENSEファイル](https://github.com/taksas/K-MoodleNotifier/blob/master/LICENSE)を参照してください。
このプロジェクト自体はMITライセンスになっています。