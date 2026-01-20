using System;
using System.Collections.Generic;
using System.IO; //Permite trabalhar com arquivos.

public class Journal // entry é a pagina, o journal é o caderno inteiro. o jornaul não escreve e nem pergunta ele só organiza e guarda
{
    public List<Entry>_entries = new List<Entry>();  // List<Entry> _entries, “Uma lista de páginas do diário”
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry); // Recebe uma entrada pronta e guarda.
    }

    public void DisplayAll() 
    {
        
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file) // Cria (ou sobrescreve) um arquivo
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date} | {entry._promptText}| {entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file) // Limpa o journal atual, Lê todas as linhas do arquivo,Reconstrói os objetos
    {
       _entries.Clear();

    if (!File.Exists(file))
    {
        Console.WriteLine("File does not exist.");
        return;
    }

    string[] lines = File.ReadAllLines(file);

    foreach (string line in lines)
    {
        if (string.IsNullOrWhiteSpace(line))
            continue;

        string[] parts = line.Split("|");

        if (parts.Length != 3)
        {
            Console.WriteLine("Invalid line skipped:");
            Console.WriteLine(line);
            continue;
        }

        Entry entry = new Entry();
        entry._date = parts[0].Trim();
        entry._promptText = parts[1].Trim();
        entry._entryText = parts[2].Trim();

        _entries.Add(entry);
    }

    Console.WriteLine("Journal loaded successfully.");
    }
}