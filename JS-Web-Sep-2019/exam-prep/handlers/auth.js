const models = require('../models');
const utils = require('../utils');
const appConfig = require('../app-config');

function login(req, res) {
  res.render('guest/login.hbs');
}

function loginPost(req, res, next) {
  const { username, password } = req.body;
  models.userModel.findOne({ username })
    .then(user => Promise.all([user, user.matchPassword(password)]))
    .then(([user, match]) => {
      if (!match) {
        res.render('guest/login.hbs', { massage: 'Wrong password or username!' });
        return;
      }
      const token = utils.jwt.createToken({ id: user._id });
      res.cookie(appConfig.authCookieName, token).redirect('/');
    });
}

function register(req, res) {
  res.render('guest/register.hbs');
  let users = models.userModel.find();
        if (users.length > 0) return;
        return models.userModel.create({
            username: 'Pesho',
            password: 123,
            roles: ['Admin']
        });
}

function registerPost(req, res, next) {
  const { username, password, repeatPassword } = req.body;
  
  if (password !== repeatPassword) {
    res.render('guest/register.hbs', {
      errors: {
        repeatPassword: 'Password and repeat password don\'t match!'
      }
    });
    return;
  }

  return models.userModel.create({ username, password, roles: ["User"] }).then(() => {
    res.redirect('/login');
  }).catch(err => {
    if (err.name === 'MongoError' && err.code === 11000) {
      res.render('guest/register.hbs', {
        errors: {
          username: 'Username already taken!'
        }
      });
      return;
    }
    next(err);
  });
}

function logout(req, res) {
  const token = req.cookies[appConfig.authCookieName];
  models.tokenBlacklistModel.create({ token }).then(() => {
    res.clearCookie(appConfig.authCookieName).redirect('/guest');
  });
}

module.exports = {
  login,
  loginPost,
  register,
  registerPost,
  logout
};