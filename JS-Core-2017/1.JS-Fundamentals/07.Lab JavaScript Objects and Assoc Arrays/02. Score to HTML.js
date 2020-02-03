function scoreToHTMLTable(scoreJSON) {
    let html = "<table>\n";
    html += "  <tr><th>name</th><th>score</th></tr>tr>\n";
    let arr = JSON.parse(scoreJSON);

    for (let obj of arr) {
        html += `  <tr><td>${htmlEscape(arr.name)}` +
            `</td><td>${arr.score}</td></tr>\n`;
    }
    html += '</table>';

    console.log(html);

    function htmlEscape(text) {
        let map = {
            '"': '&quot;', '&': '&amp;',
            "'": '&#39;', '<': '&lt;', '>': '&gt;'
        };
        return text.replace(/[\"&'<>]/g, ch => map[ch]);
    }
}

scoreToHTMLTable([{"name":"Pesho","score":70}])


