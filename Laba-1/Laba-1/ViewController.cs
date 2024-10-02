using System;
using AppKit;
using Foundation;

namespace Laba1
{
    public partial class ViewController : NSViewController
    {
        // Данные для таблицы
        private NSMutableArray tableData;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Инициализация данных для таблицы
            tableData = new NSMutableArray
            {
                new NSString("Пример строки 1"),
                new NSString("Пример строки 2")
            };

            // Проверка и установка источника данных для таблицы
            if (TAb != null)
            {
                TAb.DataSource = new TableDataSource(tableData);
            }
            else
            {
                Console.WriteLine("TAb is not initialized.");
            }

            // Изначально кнопка удаления отключена
            if (DeleteBtn != null)
            {
                DeleteBtn.Enabled = false;
            }
            else
            {
                Console.WriteLine("DeleteBtn is not initialized.");
            }
        }

        // Метод, вызываемый при нажатии на кнопку "AddButton"
        partial void AddButton(NSObject sender)
        {
            if (TAb != null && tableData != null)
            {
                // Добавляем новую строку в таблицу
                tableData.Add(new NSString("Новая строка"));
                TAb.ReloadData();  // Обновляем таблицу, чтобы новые данные отображались
            }
            else
            {
                Console.WriteLine("TAb or tableData is not initialized.");
            }
        }

    
    }

    // Источник данных для NSTableView
    public class TableDataSource : NSTableViewDataSource
    {
        private NSMutableArray data;

        public TableDataSource(NSMutableArray data)
        {
            this.data = data;
        }

        // Метод для возврата количества строк в таблице
        public override nint GetRowCount(NSTableView tableView)
        {
            return (nint)data.Count;
        }

        // Метод для получения данных для конкретной строки
        public override NSObject GetObjectValue(NSTableView tableView, NSTableColumn tableColumn, nint row)
        {
            return data.GetItem<NSString>((nuint)row);
        }
    }
}