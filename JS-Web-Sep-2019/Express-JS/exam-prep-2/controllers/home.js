const config = require('../config/config');
const models = require('../models');

module.exports = {
    get: {
        home: (req, res, next) => {

            const isLoggedIn = req.cookies[config.cookie] !== undefined
            
            res.render('home', {isLoggedIn});
            
        }
    },
};