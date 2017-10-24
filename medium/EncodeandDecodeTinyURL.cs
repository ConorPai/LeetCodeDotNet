//https://leetcode.com/problems/encode-and-decode-tinyurl/description/

using System.Collections.Generic;

public class EncodeandDecodeTinyURLDemo {

    private Dictionary<string, string> m_pUrlDict = new Dictionary<string, string>();

    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        string shortUrl = getShortUrl(longUrl);
        m_pUrlDict[shortUrl] = longUrl;
        return shortUrl;
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        if (!m_pUrlDict.ContainsKey(shortUrl))
            return "";

        return m_pUrlDict[shortUrl];
    }

    private string getShortUrl(string longUrl) {
        return longUrl;
    }
}