const { homeController, userController, courseController } = require('../controllers');
const { auth } = require('../utils');

module.exports = (app) => {
    // Users
    // app.get('/register', userController.getRegister);
    // app.post('/register', userController.register);
    // app.get('/login', userController.getLogin);
    // app.post('/login', userController.login);
    // app.get('/logout', auth(), userController.logout);
    app.get('/', auth(false), homeController.getHome);

};