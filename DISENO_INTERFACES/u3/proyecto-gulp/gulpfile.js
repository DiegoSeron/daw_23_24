var gulp = require('gulp');
const sass = require('gulp-sass')(require('sass'));
// var min = require('gulp-minify');
// var concat = require('gulp-concat');
// var cleancss = require('gulp-clean-css');

gulp.task('compile-scss', function() {
    gulp.src('D:\Diego Seron\git\DISENO DE INTERFACES\U3\proyecto-gulp\app\index.scss')
    .pipe(sass().on('error', sass.logError))
    .pipe(dest('D:\Diego Seron\git\DISENO DE INTERFACES\U3\proyecto-gulp\app\index.css'))
    });