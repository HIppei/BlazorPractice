namespace BlazorPractice.Client.States;

public class AppState
{
    private string message = "test";
    
    public string Message
    {
        get => message;
        set
        {
            message = value;
            NotifyStateChanged();
        }
    }

    // 値が変更された時に呼び出されるイベント
    // Public な Action は、イベントハンドラとして登録できる
    public event Action? OnChange;
    private void NotifyStateChanged()=> OnChange?.Invoke();
}
