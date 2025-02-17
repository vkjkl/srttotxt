using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

public class SrtConverter
{
    // 转换入口方法
    public void ConvertListBoxItems(ListBox listBox)
    {
        if (listBox.Items.Count == 0)
        {
            MessageBox.Show("请先添加SRT文件");
            return;
        }

        var successCount = 0;
        var errorFiles = new List<string>();

        foreach (var item in listBox.Items)
        {
            var srtPath = item.ToString();
            if (!ValidateFile(srtPath))
            {
                errorFiles.Add(Path.GetFileName(srtPath));
                continue;
            }

            try
            {
                var txtContent = ProcessSrtFile(srtPath);
                SaveTxtFile(srtPath, txtContent);
                successCount++;
            }
            catch (Exception ex)
            {
                errorFiles.Add($"{Path.GetFileName(srtPath)} ({ex.Message})");
            }
        }

        ShowResult(successCount, errorFiles);
    }

    // 文件验证逻辑
    private bool ValidateFile(string path)
    {
        if (!File.Exists(path))
        {
            MessageBox.Show($"文件不存在: {path}");
            return false;
        }

        if (Path.GetExtension(path).ToLower() != ".srt")
        {
            MessageBox.Show($"非SRT文件: {path}");
            return false;
        }

        return true;
    }

    // 核心转换逻辑
    private string ProcessSrtFile(string filePath)
    {
        var content = File.ReadAllText(filePath, Encoding.UTF8)
            .Replace("\r\n", "\n")  // 统一换行符
            .Replace("\r", "\n");

        var result = new StringBuilder();
        foreach (var block in content.Split(new[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries))
        {
            var lines = block.Split('\n');
            if (lines.Length < 3) continue;

            for (var i = 2; i < lines.Length; i++)
            {
                var line = lines[i].Trim();
                if (!string.IsNullOrEmpty(line))
                {
                    result.AppendLine(line);
                }
            }
        }
        return result.ToString();
    }

    // 文件保存逻辑
    private void SaveTxtFile(string srtPath, string content)
    {
        var txtPath = Path.Combine(
            Path.GetDirectoryName(srtPath),
            $"{Path.GetFileNameWithoutExtension(srtPath)}.txt"
        );

        File.WriteAllText(txtPath, content, Encoding.UTF8);
    }

    // 结果显示逻辑
    private void ShowResult(int success, List<string> errors)
    {
        var msg = new StringBuilder()
            .AppendLine($"转换完成！成功 {success} 个")
            .AppendLine("失败文件：");

        if (errors.Count > 0)
        {
            errors.ForEach(e => msg.AppendLine($"• {e}"));
        }
        else
        {
            msg.AppendLine("（无）");
        }

        MessageBox.Show(msg.ToString());
    }
}