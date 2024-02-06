var gulp = require('gulp');
var sass = require('gulp-sass')(require('sass'));
var min = require('gulp-minify');
var concat = require('gulp-concat');
var cleancss = require('gulp-clean-css');

gulp.task('compile-scss', function() {
    gulp.src('.app/index.scss')
    .pipe(sass().on('error', sass.logError))
    .pipe(dest('.app/index.css'))
    });