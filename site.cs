@import url('open-iconic/font/css/open-iconic-bootstrap.min.css');
@import url('myWSB.css');

html, body {
    font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif;
}

a, .btn-link {
    color: #0366d6;
}

.btn-primary {
    color: #fff;
    background-color: #1b6ec2;
    border-color: #1861ac;
}

app {
    position: relative;
    display: flex;
    flex-direction: column;
}

.top-row {
    height: 3.5rem;
    display: flex;
    align-items: center;
}

.main {
    flex: 1;
}

    .main .top-row {
        background-color: #f7f7f7;
        border-bottom: 1px solid #d6d5d5;
        justify-content: flex-end;
    }

        .main .top-row > a, .main .top-row .btn-link {
            white-space: nowrap;
            margin-left: 1.5rem;
        }

.main .top-row a:first-child {
    overflow: hidden;
    text-overflow: ellipsis;
}

.sidebar {
    background-image: linear-gradient(180deg, rgb(5, 39, 103) 0%, #3a0647 70%);
}

    .sidebar .top-row {
        background-color: rgba(0,0,0,0.4);
    }

    .sidebar .navbar-brand {
        font-size: 1.1rem;
    }

    .sidebar .oi {
        width: 2rem;
        font-size: 1.1rem;
        vertical-align: text-top;
        top: -2px;
    }

    .sidebar .nav-item {
        font-size: 0.9rem;
        padding-bottom: 0.5rem;
    }

        .sidebar .nav-item:first-of-type {
            padding-top: 1rem;
        }

        .sidebar .nav-item:last-of-type {
            padding-bottom: 1rem;
        }

        .sidebar .nav-item a {
            color: #d7d7d7;
            border-radius: 4px;
            height: 3rem;
            display: flex;
            align-items: center;
            line-height: 3rem;
        }

            .sidebar .nav-item a.active {
                background-color: rgba(255,255,255,0.25);
                color: white;
            }

            .sidebar .nav-item a:hover {
                background-color: rgba(255,255,255,0.1);
                color: white;
            }

.content {
    padding-top: 1.1rem;
}

.navbar-toggler {
    background-color: rgba(255, 255, 255, 0.1);
}

.valid.modified:not([type=checkbox]) {
    outline: 1px solid #26b050;
}

.invalid {
    outline: 1px solid red;
}

.validation-message {
    color: red;
}

#blazor-error-ui {
    background: lightyellow;
    bottom: 0;
    box-shadow: 0 -1px 2px rgba(0, 0, 0, 0.2);
    display: none;
    left: 0;
    padding: 0.6rem 1.25rem 0.7rem 1.25rem;
    position: fixed;
    width: 100%;
    z-index: 1000;
}

#blazor-error-ui .dismiss {
    cursor: pointer;
    position: absolute;
    right: 0.75rem;
    top: 0.5rem;
}

@media (max-width: 767.98px) {
    .main .top-row:not(.auth) {
        display: none;
    }

    .main .top-row.auth {
        justify-content: space-between;
    }

    .main .top-row a, .main .top-row .btn-link {
        margin-left: 0;
    }
}

@media (min-width: 768px) {
    app {
        flex-direction: row;
    }

    .sidebar {
        width: 250px;
        height: 100vh;
        position: sticky;
        top: 0;
    }

    .main .top-row {
        position: sticky;
        top: 0;
    }

    .main > div {
        padding-left: 2rem !important;
        padding-right: 1.5rem !important;
    }

    .navbar-toggler {
        display: none;
    }

    .sidebar .collapse {
        /* Never collapse the sidebar for wide screens */
        display: block;
    }
}
