/**
 * @param {String} tweet
 * @returns {String[]}
 */
module.exports = function (tweet) {
    const arr = tweet.split(' ');
    const tags = [];
    let counter = 0;
    arr.forEach((element) => {
        ++counter;
        if(element.includes('#')) {
            let tmp = ''
            for(let i = 0; i < element.length; ++i) {
                if(element[i] !== '#') {
                    tmp += element[i];
                }
            }
            tags.push(tmp);
        }
    })

   // console.log(tags);
    return tags;
};
