function extract(arr) {
    let validLinks = [];
    let pattern = /www\.([A-Za-z\dz-]+)(\.[a-z]+)+/g;
    for (let sentance of arr) {
        let match = pattern.exec(sentance);
        while (match) {
            validLinks.push(match[0]);
            match = pattern.exec(sentance);
        }
    }

    return validLinks.join('\n');
}

console.log(extract([
    'Join WebStars now for free, at www.web-stars.com',
    'You can also support our partners:',
    'Internet - www.internet.com',
    'WebSpiders - www.webspiders101.com',
    'Sentinel - www.sentinel.-ko'
]));