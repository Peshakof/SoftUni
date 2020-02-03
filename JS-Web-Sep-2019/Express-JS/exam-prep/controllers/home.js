const { courseModel } = require('../models');

function getHome(req, res) {
    const user = req.user;
    res.render('index', { user });
}

module.exports = {
    getHome
};