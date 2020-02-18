pipeline {
  agent any
  stages {
    stage('UI Test') {
      steps {
        echo 'running tests'
        git(url: 'https://github.com/clev51/ColourGen', branch: 'master')
      }
    }

  }
  environment {
    COMPLETED_MSG = '"Build Done!"'
  }
}