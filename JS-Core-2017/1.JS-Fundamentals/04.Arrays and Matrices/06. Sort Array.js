function sort(arr) {
    
    arr.sort((a,b) => {
        return a.length - b.length || a.localeCompare(b);
    });
    console.log(arr.join('\n'));
}

sort([
    'alpha',
    'beta',
    'gamma'
    ]
);