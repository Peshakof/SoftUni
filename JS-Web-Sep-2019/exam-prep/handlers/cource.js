const models = require('../models');

function index (req, res) {
    const user = req.user;
    if(user.roles.indexOf("Admin") === -1) {
        models.courceModel.find()
            .where({isPublic: true})
            .then((cources) => {
                res.render('user/home.hbs', {cources, user});
            })
    } else {
        models.courceModel.find().populate('lectures')
            .then((cources) => {
                res.render('admin/home.hbs', {cources});
            })
            .catch((err)=>{
                console.log(err);
            })
    }
}

function guestHome (req,res) {
    models.courceModel.find()
    .where({isPublic: true})
    .limit(3)
    .then((cources) => {
        res.render('guest/home.hbs', {cources});
    })
    .catch((err)=>{
        console.log(err);
    })
}

function getCreateCource(req,res) {
    res.render('admin/createCource.hbs');
}

function postCreateCource(req,res) {
    const {title,description,imageUrl,isPublic} = req.body;
    
    models.courceModel.create({
        title,
        description,
        imageUrl,
        isPublic: isPublic == "on"
    }).then(() => {
        res.redirect('/');
    })
    .catch(err=>console.log(err));
}

function editCource(req,res) {
    const id = req.params.id;
    models.courceModel.findById(id)
        .then((cource) => {
            res.render('admin/editCource.hbs', cource);
        })
        .catch((err) => {
            console.log(err);
        })
}

function postEditCource(req,res) {
    const id = req.params.id;
    const {title, description, imageUrl, isPublic} = req.body;
    models.courceModel.updateOne({_id: id}, {title,description,imageUrl,isPublic: isPublic == 'on'})
        .then(() => {
            res.redirect('/');
        })
        .catch((err)=>{
            console.log(err);
        })
}

function details(req,res) {
    const id = req.params.id;
    const user = req.user; 
    models.courceModel.findById(id).populate('lectures')
    .then((cource) => {
            res.render('user/detailsEnrolled.hbs', {cource, user});
        })
        .catch((err)=>{
            console.log(err);
        })
}

function getLecturePage(req,res) {
    const id = req.params.id;
    Promise.all([
        models.courceModel.findById(id).populate('lectures'),
        models.lectureModel.find().where({cource:id})
    ])
    .then(([cource,lectures])=>{
        const countOfLectures = lectures.length;
        res.render('admin/lecturePanel.hbs', {cource,lectures,countOfLectures});  
        })
        .catch((err)=>{
            console.log(err);
        })
}

function addLecture(req,res) {
    const id = req.params.id;
    const {title,videoUrl} = req.body;
    const lecture = models.lectureModel.create({
        title,
        videoUrl,
        cource: id
    });
    models.courceModel.updateOne({_id: id}, {$push: {lectures: lecture._id}})
        .then(()=>{
            res.redirect('/');
        })
        .catch((err)=>{
            console.log(err);
        }) 
}

function deleteLecture(req,res) {
    const id = req.params.id;
    models.lectureModel.deleteOne({_id: id})
        .then(()=>{
            res.redirect('/');
        })
        .catch((err)=>{
            console.log(err);
        }) 
}

module.exports = {
    index,
    guestHome,
    getCreateCource,
    postCreateCource,
    editCource,
    postEditCource,
    details,
    addLecture,
    getLecturePage,
    deleteLecture
}