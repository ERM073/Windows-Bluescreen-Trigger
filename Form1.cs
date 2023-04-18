private void button1_Click(object sender, EventArgs e)
{
    try
    {
        string[] processNames = { "svchost", "spoolsv", "dllhost" }; // 停止するプロセス名を指定する
        foreach (var processName in processNames)
        {
            foreach (var process in Process.GetProcessesByName(processName))
            {
                process.Kill(); // プロセスを停止する
            }
        }
        MessageBox.Show("完了");
    }
    catch (Exception ex)
    {
        MessageBox.Show($"プロセスの停止中にエラーが発生しました。\n{ex.Message}");
    }
}
