const { auth } = require('../utils');
const authHandler = require('../handlers/auth');
const courceHandler = require('../handlers/cource');

module.exports = (app) => {

    // user routes
    app.get('/', auth(), courceHandler.index);
    app.get('/guest', courceHandler.guestHome);
    app.get('/login', authHandler.login);
    app.post('/login', authHandler.loginPost);
    app.get('/register', authHandler.register);
    app.post('/register', authHandler.registerPost);
    app.post('/logout', authHandler.logout);

    //user cources routes
    app.get('/details/:id', auth(), courceHandler.details);

    // admin routes
    app.get('/create', auth(), courceHandler.getCreateCource);
    app.post('/create', auth(), courceHandler.postCreateCource);
    app.get('/edit/:id', auth(), courceHandler.editCource);
    app.post('/edit/:id', auth(), courceHandler.postEditCource);
    app.get('/addLecture/:id', auth(), courceHandler.getLecturePage);
    app.post('/addLecture/:id',auth(), courceHandler.addLecture);
    app.get('/delete/:id', auth(), courceHandler.deleteLecture);
}