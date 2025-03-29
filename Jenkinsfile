node {
    stage 'Checkout' {
        checkout scm
    }

    stage 'Build' {
        if (env.BRANCH_NAME == 'main') {
            echo 'I only execute on the master branch'
        } else {
            echo 'I execute elsewhere'
        }
    }
}
