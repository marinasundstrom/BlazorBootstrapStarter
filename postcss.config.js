var autoprefixer = require('autoprefixer');
//var copyAssets = require('postcss-copy-assets');

module.exports = {
    map: true,
    plugins: [
        autoprefixer(),
        //copyAssets({ base: '.' })
    ]
}