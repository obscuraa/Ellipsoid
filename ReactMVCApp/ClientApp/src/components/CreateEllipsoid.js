﻿import React, { Component } from 'react';

export class CreateEllipsoid extends Component {

    render() {
        return (
            <>
                <h1>Create Ellipsoid object</h1>

                <div class="row">
                    <div class="col-6">
                        <form asp-controller="Ellipsoid" asp-action="CreateEllipsoid" method="post">
                            <div class="mb-3">
                                <label class="form-label">Enter X coordinate</label>
                                <input asp-for="X" type="number" class="form-control" />
                            </div>
                            <div class="mb-3">
                                <label class="form-label">Enter Y coordinate</label>
                                <input asp-for="Y" type="number" class="form-control" />
                            </div>
                            <div class="mb-3">
                                <label class="form-label">Enter Z coordinate</label>
                                <input asp-for="Z" type="number" class="form-control" />
                            </div>
                            <div class="mb-3">
                                <label class="form-label">Choose bounding area</label>
                                <input asp-for="BoundingArea" type="text" class="form-control" list="exampleList" />
                                <datalist id="exampleList">
                                    <option value="Sphere" />
                                    <option value="Cube" />
                                    <option value="testing" />
                                </datalist>
                            </div>
                            <div>
                                <button type="submit" class="btn btn-primary ">Save</button>
                            </div>
                        </form>
                    </div>
                </div>
            </>
        );
    }
}